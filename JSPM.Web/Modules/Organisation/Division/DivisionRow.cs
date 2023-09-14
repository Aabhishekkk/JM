using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Division]")]
[DisplayName("Division"), InstanceName("Division")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class DivisionRow : Row<DivisionRow.RowFields>, IIdRow, INameRow
{
    const string jInstitute = nameof(jInstitute);
    const string jBranch = nameof(jBranch);
    const string jDepartment = nameof(jDepartment);
    const string jAcademicYears = nameof(jAcademicYears);
    const string jSemester = nameof(jSemester);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Institute"), ForeignKey("[organisation].[Institute]", "Id"), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    public int? InstituteId
    {
        get => fields.InstituteId[this];
        set => fields.InstituteId[this] = value;
    }

    [DisplayName("Branch"), Column("Branch Id"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
    public int? BranchId
    {
        get => fields.BranchId[this];
        set => fields.BranchId[this] = value;
    }

    [DisplayName("Department"), Column("Department Id"), ForeignKey("[organisation].[Departments]", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    public int? DepartmentId
    {
        get => fields.DepartmentId[this];
        set => fields.DepartmentId[this] = value;
    }

    [DisplayName("Academic Years"), Column("AcademicYears Id"), ForeignKey("[organisation].[AcademicYears ]", "Id"), LeftJoin(jAcademicYears)]
    public int? AcademicYearsId
    {
        get => fields.AcademicYearsId[this];
        set => fields.AcademicYearsId[this] = value;
    }

    [DisplayName("Semester"), Column("Semester Id"), ForeignKey("[organisation].[Semesters ]", "Id"), LeftJoin(jSemester)]
    public int? SemesterId
    {
        get => fields.SemesterId[this];
        set => fields.SemesterId[this] = value;
    }

    [DisplayName("Start Date"), Column("Start Date"), NotNull]
    public DateTime? StartDate
    {
        get => fields.StartDate[this];
        set => fields.StartDate[this] = value;
    }

    [DisplayName("End Date"), Column("End Date")]
    public DateTime? EndDate
    {
        get => fields.EndDate[this];
        set => fields.EndDate[this] = value;
    }

    [DisplayName("Division Name"), Column("Division Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string DivisionName
    {
        get => fields.DivisionName[this];
        set => fields.DivisionName[this] = value;
    }

    [DisplayName("Institute Institute Name"), Expression($"{jInstitute}.[Institute Name]")]
    public string InstituteName
    {
        get => fields.InstituteName[this];
        set => fields.InstituteName[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    [DisplayName("Department Department Name"), Expression($"{jDepartment}.[Department Name]")]
    public string DepartmentName
    {
        get => fields.DepartmentName[this];
        set => fields.DepartmentName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field InstituteId;
        public Int32Field BranchId;
        public Int32Field DepartmentId;
        public Int32Field AcademicYearsId;
        public Int32Field SemesterId;
        public DateTimeField StartDate;
        public DateTimeField EndDate;
        public StringField DivisionName;

        public StringField InstituteName;
        public StringField BranchName;
        public StringField DepartmentName;
    }
}