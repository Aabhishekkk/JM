using JSPM.Organisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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
using MyRow = JSPM.Students.ProjectRow;

namespace JSPM.Students.Endpoints;

[Route("Services/Students/Project/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class ProjectEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IProjectSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IProjectSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IProjectDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IProjectRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IProjectListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IProjectListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.ProjectColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "ProjectList_" +
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

                string StudentId = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(StudentId))
                {
                    var StudentMaster = uow.Connection.TryFirst<PersonalRow>(PersonalRow.Fields.FirstName == StudentId);
                    if (StudentMaster != null)
                        Row.StudentId = StudentMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid DepartmentId!");
                        continue;
                    }
                }

                Row.Type = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Type))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Type Not found");
                    continue;
                }

                Row.ProjectTitle = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.ProjectTitle))
                {
                    response.ErrorList.Add("Error On Row " + row + ": ProjectTitle Not found");
                    continue;
                }

                Row.ProjectDetails = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.ProjectDetails))
                {
                    response.ErrorList.Add("Error On Row " + row + ": ProjectDetails Not found");
                    continue;
                }

                Row.ProjectReport = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.ProjectReport))
                {
                    response.ErrorList.Add("Error On Row " + row + ": ProjectReport Not found");
                    continue;
                }

                string DepartmentId = Convert.ToString(worksheet.Cells[row, 6].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var DepartmentMaster = uow.Connection.TryFirst<DepartmentsRow>(DepartmentsRow.Fields.DepartmentName == DepartmentId);
                    if (DepartmentMaster != null)
                        Row.DepartmentId = DepartmentMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid DepartmentId!");
                        continue;
                    }
                }

                string SemesterId = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(SemesterId))
                {
                    var CourseMaster = uow.Connection.TryFirst<SemestersRow>(SemestersRow.Fields.Semester== SemesterId);
                    if (CourseMaster != null)
                        Row.SemesterId = CourseMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid SemesterId!");
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
