using Azure;
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
using MyRow = JSPM.Organisation.DivisionRow;

namespace JSPM.Organisation.Endpoints;

[Route("Services/Organisation/Division/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class DivisionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IDivisionSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IDivisionSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IDivisionDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
   [FromServices] IUploadStorage uploadStorage,
   [FromServices] IDivisionSaveHandler handler)
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

                Row.DivisionName = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.DivisionName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": InstituteName Not found");
                    continue;
                }

                string InstituteId = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(InstituteId))
                {
                    var IMaster = uow.Connection.TryFirst<InstituteRow>(InstituteRow.Fields.InstituteName == InstituteId);
                    if (IMaster != null)
                        Row.InstituteId = IMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid InstituteId!");
                        continue;
                    }
                }

                string BranchId = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(BranchId))
                {
                    var BMaster = uow.Connection.TryFirst<BranchesRow>(BranchesRow.Fields.BranchName == BranchId);
                    if (BMaster != null)
                        Row.BranchId = BMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid BranchId!");
                        continue;
                    }
                }

                string DepartmentId = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var DMaster = uow.Connection.TryFirst<DepartmentsRow>(DepartmentsRow.Fields.DepartmentName == DepartmentId);
                    if (DMaster != null)
                        Row.DepartmentId = DMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid DepartmentId!");
                        continue;
                    }
                }
                string AcademicYearId = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(AcademicYearId))
                {
                    var AMaster = uow.Connection.TryFirst<AcademicYearsRow>(AcademicYearsRow.Fields.AcademicYear == AcademicYearId);
                    if (AMaster != null)
                        Row.DepartmentId = AMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid AcademicYearId!");
                        continue;
                    }
                }

                string SemesterId = Convert.ToString(worksheet.Cells[row, 6].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(SemesterId))
                {
                    var AMaster = uow.Connection.TryFirst<SemestersRow>(SemestersRow.Fields.Semester == SemesterId);
                    if (AMaster != null)
                        Row.DepartmentId = AMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid SemesterId!");
                        continue;
                    }
                }




                Row.StartDate = Convert.ToDateTime(worksheet.Cells[row, 7].Value ?? null);
                Row.EndDate = Convert.ToDateTime(worksheet.Cells[row, 8].Value ?? null);




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