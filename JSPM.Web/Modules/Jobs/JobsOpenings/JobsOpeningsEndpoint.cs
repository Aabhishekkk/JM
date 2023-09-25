using JSPM.Organisation;
using JSPM.Students;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = JSPM.Jobs.JobsOpeningsRow;

namespace JSPM.Jobs.Endpoints;

[Route("Services/Jobs/JobsOpenings/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class JobsOpeningsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IJobsOpeningsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IJobsOpeningsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IJobsOpeningsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IJobsOpeningsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IJobsOpeningsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IJobsOpeningsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.JobsOpeningsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "JobsOpeningsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
      [FromServices] IUploadStorage uploadStorage,
      [FromServices] IProjectSaveHandler handler)
    {

        if (request is null)
            throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName))
            throw new ArgumentNullException(nameof(request.FileName));

        if (uploadStorage is null)
            throw new ArgumentNullException(nameof(uploadStorage));

        UploadPathHelper.CheckFileNameSecurity(request.FileName);

        if (!request.FileName.StartsWith("temporary/", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException(nameof(request.FileName));

        ExcelPackage ep = new();
        using (var fs = uploadStorage.OpenFile(request.FileName))
            ep.Load(fs);

        var p = MyRow.Fields;
        //var p = ProductsRow.Fields;

        var response = new ExcelImportResponse
        {
            ErrorList = new List<string>()
        };

        var worksheet = ep.Workbook.Worksheets[0];


        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
        {
            try
            {
                MyRow Row = new MyRow();

                Row.TypeOfEmployement = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.TypeOfEmployement))
                {
                    response.ErrorList.Add("Error On Row " + row + ": TypeOfEmployement Not found");
                    continue;
                }
                Row.Description = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Description))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Description Not found");
                    continue;
                }
                Row.Levels = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Levels))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Levels Not found");
                    continue;
                }
                Row.Vacancy = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? null);

                Row.CompanyName = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CompanyName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": CompanyName Not found");
                    continue;
                }
                Row.Location = Convert.ToString(worksheet.Cells[row, 6].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Location))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Location Not found");
                    continue;
                }
                Row.Role = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Role))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Role Not found");
                    continue;
                }

                Row.Budget = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Budget))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Budget Not found");
                    continue;
                }
                Row.Shift = Convert.ToString(worksheet.Cells[row, 9].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Shift))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Shift Not found");
                    continue;
                }
                Row.Skills = Convert.ToString(worksheet.Cells[row, 10].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Skills))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Skills Not found");
                    continue;
                }

                string SkillsId = Convert.ToString(worksheet.Cells[row, 11].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(SkillsId))
                {
                    var SMaster = uow.Connection.TryFirst<StudentsSkillsRow>(StudentsSkillsRow.Fields.SkillName == SkillsId);
                    if (SMaster != null)
                        Row.SkillsId = SMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid DepartmentId!");
                        continue;
                    }
                }

                uow.Connection.Insert(Row);

                response.Inserted = response.Inserted + 1;

            }
            catch (Exception)
            {
                //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                throw;
            }
        }
        return response;
    }
}
