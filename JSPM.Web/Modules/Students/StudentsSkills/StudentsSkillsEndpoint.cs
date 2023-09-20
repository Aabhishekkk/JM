using JSPM.Master;
using JSPM.Organisation;
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
using MyRow = JSPM.Students.StudentsSkillsRow;

namespace JSPM.Students.Endpoints;

[Route("Services/Students/StudentsSkills/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class StudentsSkillsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentsSkillsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentsSkillsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }

    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IStudentsSkillsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IStudentsSkillsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IStudentsSkillsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IStudentsSkillsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.StudentsSkillsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "StudentsSkillsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
}

//    [HttpPost]
//    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
//   [FromServices] IUploadStorage uploadStorage,
//   [FromServices] IProjectSaveHandler handler)
//    {

//        if (request is null)
//            throw new ArgumentNullException(nameof(request));
//        if (string.IsNullOrWhiteSpace(request.FileName))
//            throw new ArgumentNullException(nameof(request.FileName));

//        if (uploadStorage is null)
//            throw new ArgumentNullException(nameof(uploadStorage));

//        UploadPathHelper.CheckFileNameSecurity(request.FileName);

//        if (!request.FileName.StartsWith("temporary/", StringComparison.OrdinalIgnoreCase))
//            throw new ArgumentOutOfRangeException(nameof(request.FileName));

//        ExcelPackage ep = new();
//        using (var fs = uploadStorage.OpenFile(request.FileName))
//            ep.Load(fs);

//        var p = MyRow.Fields;
//        //var p = ProductsRow.Fields;

//        var response = new ExcelImportResponse
//        {
//            ErrorList = new List<string>()
//        };

//        var worksheet = ep.Workbook.Worksheets[0];


//        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
//        {
//            try
//            {
//                MyRow Row = new MyRow();

//                Row.ESkillCategory = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
//                if (string.IsNullOrEmpty(Row.ESkillCategory))
//                {
//                    response.ErrorList.Add("Error On Row " + row + ": ESkillCategory Not found");
//                    continue;
//                }

//                string SkillId = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
//                if (!string.IsNullOrEmpty(SkillId))
//                {
//                    var SkillMaster = uow.Connection.TryFirst<SkillsRow>(SkillsRow.Fields.Name == SkillId);
//                    if (SkillMaster != null)
//                        Row.SkillId = SkillMaster.Id;
//                    else
//                    {
//                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
//                        continue;
//                    }
//                }
//                Row.Rating = Convert.ToInt32(worksheet.Cells[row, 3].Value ?? null);


//                Row.AknowledgeBy = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
//                if (string.IsNullOrEmpty(Row.AknowledgeBy))
//                {
//                    response.ErrorList.Add("Error On Row " + row + ": AknowledgeBy Not found");
//                    continue;
//                }
//                Row.Certification = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
//                if (string.IsNullOrEmpty(Row.Certification))
//                {
//                    response.ErrorList.Add("Error On Row " + row + ": Certification Not found");
//                    continue;
//                }
               



//                uow.Connection.Insert(Row);

//                response.Inserted = response.Inserted + 1;

//            }
//            catch (Exception)
//            {
//                //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
//                throw;
//            }
//        }
//        return response;
//    }
//}












