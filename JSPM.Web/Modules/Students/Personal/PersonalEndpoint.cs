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
using MyRow = JSPM.Students.PersonalRow;

namespace JSPM.Students.Endpoints;

[Route("Services/Students/Personal/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class PersonalEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPersonalSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPersonalSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IPersonalDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IPersonalRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IPersonalListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IPersonalListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.PersonalColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "PersonalList_" +
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

                Row.FirstName = Convert.ToString(worksheet.Cells[row, 1].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.FirstName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": FirstName Not found");
                    continue;
                }
                Row.MiddleName = Convert.ToString(worksheet.Cells[row, 2].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.MiddleName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": MiddleName Not found");
                    continue;
                }
                Row.LastName = Convert.ToString(worksheet.Cells[row, 3].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.LastName))
                {
                    response.ErrorList.Add("Error On Row " + row + ": LastName Not found");
                    continue;
                }


                Row.Email = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Email))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Email Not found");
                    continue;
                }
                Row.MobileNumber = Convert.ToString(worksheet.Cells[row, 5].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.MobileNumber))
                {
                    response.ErrorList.Add("Error On Row " + row + ": MobileNumber Not found");
                    continue;
                }

                Row.Pnr = Convert.ToString(worksheet.Cells[row, 6].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Pnr))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Pnr Not found");
                    continue;
                }
                Row.PermanentAddress = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.PermanentAddress))
                {
                    response.ErrorList.Add("Error On Row " + row + ": PermanentAddress Not found");
                    continue;
                }
                Row.City = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.City))
                {
                    response.ErrorList.Add("Error On Row " + row + ": City Not found");
                    continue;
                }



                Row.Pin = Convert.ToInt32(worksheet.Cells[row, 9].Value ?? null);

                Row.CurrentAddress = Convert.ToString(worksheet.Cells[row, 10].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CurrentAddress))
                {
                    response.ErrorList.Add("Error On Row " + row + ":  CurrentAddress Not found");
                    continue;
                }
                Row.CurrentCity = Convert.ToString(worksheet.Cells[row, 11].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CurrentCity))
                {
                    response.ErrorList.Add("Error On Row " + row + ":  CurrentCity Not found");
                    continue;
                }
                Row.CurrentState = Convert.ToString(worksheet.Cells[row, 12].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.CurrentState))
                {
                    response.ErrorList.Add("Error On Row " + row + ":  CurrentState Not found");
                    continue;
                }

                Row.Gender = Convert.ToString(worksheet.Cells[row, 13].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Gender))
                {
                    response.ErrorList.Add("Error On Row " + row + ":  Gender Not found");
                    continue;
                }
                Row.Dob= Convert.ToDateTime(worksheet.Cells[row, 14].Value ?? 0);

                Row.AdmissionDate = Convert.ToDateTime(worksheet.Cells[row, 15].Value ?? 0);


                string DepartmentId = Convert.ToString(worksheet.Cells[row, 16].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var DepartmentMaster = uow.Connection.TryFirst<DepartmentsRow>(DepartmentsRow.Fields.DepartmentName == DepartmentId);
                    if (DepartmentMaster != null)
                        Row.DepartmentId = DepartmentMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                        continue;
                    }
                }
                string BranchId = Convert.ToString(worksheet.Cells[row, 17].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var BranchMaster = uow.Connection.TryFirst<BranchesRow>(BranchesRow.Fields.BranchName == BranchId);
                    if (BranchMaster != null)
                        Row.BranchId = BranchMaster.Id;
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid Course!");
                        continue;
                    }
                }

                string DivisionId = Convert.ToString(worksheet.Cells[row, 18].Value ?? "").Trim();
                if (!string.IsNullOrEmpty(DepartmentId))
                {
                    var DivisionMaster = uow.Connection.TryFirst<DivisionRow>(DivisionRow.Fields.DivisionName == DivisionId);
                    if (DivisionMaster != null)
                        Row.DivisionId = DivisionMaster.Id;
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



