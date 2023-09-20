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
using MyRow = JSPM.Organisation.BranchesRow;

namespace JSPM.Organisation.Endpoints;

[Route("Services/Organisation/Branches/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class BranchesEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IBranchesSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IBranchesSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IBranchesDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IBranchesRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IBranchesListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IBranchesListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.BranchesColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "BranchesList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
    [FromServices] IUploadStorage uploadStorage,
    [FromServices] IBranchesSaveHandler handler)
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

                 Row.BranchName = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                 if (string.IsNullOrEmpty(Row.BranchName))
                 {
                     response.ErrorList.Add("Error On Row " + row + ": BranchName Not found");
                     continue;
                 }

                 Row.BranchCode = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                 if (string.IsNullOrEmpty(Row.BranchCode))
                 {
                     response.ErrorList.Add("Error On Row " + row + ": BranchCode Not found");
                     continue;
                 }

                string InstituteId = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(InstituteId))
                {
                    var CourseMaster = uow.Connection.TryFirst<InstituteRow>(InstituteRow.Fields.InstituteName == InstituteId);
                    if (CourseMaster != null)
                        Row.InstituteId = CourseMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                        continue;
                    }
                }
                

                string DepartmentId = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var CourseMaster = uow.Connection.TryFirst<DepartmentsRow>(DepartmentsRow.Fields.DepartmentName == DepartmentId);
                    if (CourseMaster != null)
                        Row.DepartmentId = CourseMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
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
