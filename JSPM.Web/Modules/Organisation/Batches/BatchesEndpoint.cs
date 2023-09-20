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
using MyRow = JSPM.Organisation.BatchesRow;

namespace JSPM.Organisation.Endpoints;

[Route("Services/Organisation/Batches/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class BatchesEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IBatchesSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IBatchesSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IBatchesDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IBatchesRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IBatchesListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IBatchesListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.BatchesColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "BatchesList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
     [FromServices] IUploadStorage uploadStorage,
     [FromServices] IBatchesSaveHandler handler)
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

                

               

                string DivisionId = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DivisionId))
                {
                    var CourseMaster = uow.Connection.TryFirst<DivisionRow>(DivisionRow.Fields.DivisionName == DivisionId);
                    if (CourseMaster != null)
                        Row.DivisionId = CourseMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid DivisionId!");
                        continue;
                    }
                }

                Row.BatchName = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.BatchName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": BranchName Not found");
                    continue;
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
