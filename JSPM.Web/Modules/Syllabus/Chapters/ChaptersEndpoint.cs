using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using OfficeOpenXml;
using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using MyRow = JSPM.Syllabus.ChaptersRow;

namespace JSPM.Syllabus.Endpoints;

[Route("Services/Syllabus/Chapters/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class ChaptersEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IChaptersSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IChaptersSaveHandler handler)
    {
        return handler.Update(uow, request);
    }

    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IChaptersDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IChaptersRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IChaptersListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IChaptersListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.ChaptersColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "ChaptersList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
    [FromServices] IUploadStorage uploadStorage,
    [FromServices] IChaptersSaveHandler handler)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName))
            throw new ArgumentNullException(nameof(request.FileName));
        if (uploadStorage is null)
            throw new ArgumentNullException(nameof(uploadStorage));
        UploadPathHelper.CheckFileNameSecurity(request.FileName);
        if (!request.FileName.StartsWith("temporary/",
       StringComparison.OrdinalIgnoreCase))
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
                string SubjectId = Convert.ToString(worksheet.Cells[row, 1].Value ??
               "").Trim();
                if (!string.IsNullOrEmpty(SubjectId))
                {
                    var CourseMaster =
                   uow.Connection.TryFirst<SubjectsRow>(SubjectsRow.Fields.SubjectName == SubjectId);
                    if (CourseMaster != null)
                        Row.SubjectId = CourseMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid SubjectId!");
                        continue;
                    }
                }
                Row.ChapterName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.ChapterName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": ChapterName Not found");
                    continue;
                }
                Row.Description = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Description))
                {
                    response.ErrorList.Add("Error On Row " + row + ": SubjectName Not found");
                    continue;
                }
                Row.Index = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? "");
                
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


            

            
    
    

