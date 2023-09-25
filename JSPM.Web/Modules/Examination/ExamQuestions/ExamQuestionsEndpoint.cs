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
using MyRow = JSPM.Examination.ExamQuestionsRow;

namespace JSPM.Examination.Endpoints;

[Route("Services/Examination/ExamQuestions/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class ExamQuestionsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IExamQuestionsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IExamQuestionsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }

    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IExamQuestionsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IExamQuestionsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IExamQuestionsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IExamQuestionsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.ExamQuestionsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "ExamQuestionsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }

    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
    [FromServices] IUploadStorage uploadStorage,
    [FromServices] IExamQuestionsSaveHandler handler)
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

                Row.Id = Convert.ToInt64(worksheet.Cells[row, 1].Value ?? null);


                Row.SubId = Convert.ToInt64(worksheet.Cells[row, 2].Value ?? null);

                Row.QuestionNumber = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.QuestionNumber))
                {
                    response.ErrorList.Add("Error On Row " + row + ": QuestionNumber Not found");
                    continue;
                }

                Row.QuestionDescription = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.QuestionDescription))
                {
                    response.ErrorList.Add("Error On Row " + row + ": BranchCode Not found");
                    continue;
                }
                Row.QuestionType = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.QuestionType))
                {
                    response.ErrorList.Add("Error On Row " + row + ": BranchCode Not found");
                    continue;
                }

                Row.Marks = Convert.ToInt64(worksheet.Cells[row, 6].Value ?? null);


                string SemId = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(SemId))
                {
                    var SemMaster = uow.Connection.TryFirst<SemestersRow>(SemestersRow.Fields.Semester == SemId);
                    if (SemMaster != null)
                        Row.SemId = SemMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid SemId!");
                        continue;
                    }
                }


                string BranchId = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(BranchId))
                {
                    var BranchMaster = uow.Connection.TryFirst<BranchesRow>(BranchesRow.Fields.BranchName == BranchId);
                    if (BranchMaster != null)
                        Row.BranchId = BranchMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid BranchId");
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