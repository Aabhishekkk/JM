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
using MyRow = JSPM.Students.AcademicsRow;

namespace JSPM.Students.Endpoints;

[Route("Services/Students/Academics/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class AcademicsEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicsSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicsSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IAcademicsDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IAcademicsRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicsListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicsListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.AcademicsColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "AcademicsList_" +
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
                Row.CourseLevel = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CourseLevel))
                {
                    response.ErrorList.Add("Error On Row " + row + ": CourseLevel Not found");
                    continue;
                }
                Row.CourseName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CourseName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": CourseName Not found");
                    continue;
                }


                Row.YearOfPassing = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.YearOfPassing))
                {
                    response.ErrorList.Add("Error On Row " + row + ": YearOfPassing Not found");
                    continue;
                }
                Row.Percentage = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Percentage))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Percentage Not found");
                    continue;
                }

                Row.Remark = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Remark))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Remark Not found");
                    continue;
                }
                Row.PassingType = Convert.ToString(worksheet.Cells[row, 6].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.PassingType))
                {
                    response.ErrorList.Add("Error On Row " + row + ": PassingType Not found");
                    continue;
                }
                string ProjectId = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(ProjectId))
                {
                    var PMaster = uow.Connection.TryFirst<ProjectRow>(ProjectRow.Fields.ProjectTitle == ProjectId);
                    if (PMaster != null)
                        Row.ProjectId = PMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                        continue;
                    }

                    string StudentId = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
                    if (!string.IsNullOrEmpty(StudentId))
                    {
                        var StudentMaster = uow.Connection.TryFirst<PersonalRow>(PersonalRow.Fields.FirstName == StudentId);
                        if (StudentMaster != null)
                            Row.StudentId = StudentMaster.Id;
                        else
                        {
                            response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                            continue;
                        }

                        string SkillId = Convert.ToString(worksheet.Cells[row, 9].Value ?? "").Trim();
                        if (!string.IsNullOrEmpty(SkillId))
                        {
                            var SkillsMaster = uow.Connection.TryFirst<StudentsSkillsRow>(StudentsSkillsRow.Fields.SkillName == SkillId);
                            if (SkillsMaster != null)
                                Row.SkillId = SkillsMaster.Id;
                            else
                            {
                                response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                                continue;
                            }

                        }
                        uow.Connection.Insert(Row);

                        response.Inserted = response.Inserted + 1;

                    }
                }
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