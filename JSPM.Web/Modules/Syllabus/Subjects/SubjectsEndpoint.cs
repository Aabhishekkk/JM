using JSPM.Organisation;
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
using MyRow = JSPM.Syllabus.SubjectsRow;

namespace JSPM.Syllabus.Endpoints;

[Route("Services/Syllabus/Subjects/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class SubjectsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ISubjectsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ISubjectsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ISubjectsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] ISubjectsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] ISubjectsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] ISubjectsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.SubjectsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "SubjectsList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
    [FromServices] IUploadStorage uploadStorage,
    [FromServices] ISubjectsSaveHandler handler)
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

                Row.SubjectCode = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.SubjectCode))
                {
                    response.ErrorList.Add("Error On Row " + row + ": SubjectCode Not found");
                    continue;
                }

                Row.SubjectName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.SubjectName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": SubjectName Not found");
                    continue;
                }

                /*string BranchID = Convert.ToString(worksheet.Cells[row,3 ].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(BranchID))
                {
                    var BranchMaster =
                   uow.Connection.TryFirst<BranchesRow>(BranchesRow.Fields.BranchName == BranchID);
                    if (BranchMaster != null)
                        Row.Id = BranchMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Branch!");
                    continue;
                    }
                }*/
                
                        string BranchID = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim(); // Change the column index to 1
                        if (!string.IsNullOrEmpty(BranchID))
                        {
                            var BranchMaster = uow.Connection.TryFirst<BranchesRow>(BranchesRow.Fields.BranchName == BranchID);
                            if (BranchMaster != null)
                                Row.BranchId = BranchMaster.Id; // Change "CourseId" to "BranchId"
                            else
                            {
                                response.ErrorList.Add("Error On Row " + row + ": Invalid Branch!");
                                continue;
                            }
                        }

                string AcademicYearID = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim(); // Change the column index to 1
                if (!string.IsNullOrEmpty(AcademicYearID))
                {
                    var AMaster = uow.Connection.TryFirst<AcademicYearsRow>(AcademicYearsRow.Fields.AcademicYear == AcademicYearID);
                    if (AMaster != null)
                        Row.AcademicYearId = AMaster.Id; // Change "CourseId" to "BranchId"
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Branch!");
                        continue;
                    }
                }



                string SemId = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(SemId))
                {
                    var SemMaster =
                   uow.Connection.TryFirst<SemestersRow>(SemestersRow.Fields.Semester == SemId);
                    if (SemMaster != null)
                        Row.SemesterId = SemMaster.Id;
                    else

                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid SemID!");
                        continue;
                    }
                }
                Row.Priority = Convert.ToInt16(worksheet.Cells[row, 6].Value ?? "");
                
                Row.Description = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Description))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Description Not found");
                    continue;
                }
                Row.SubjectType = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
               
                
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
