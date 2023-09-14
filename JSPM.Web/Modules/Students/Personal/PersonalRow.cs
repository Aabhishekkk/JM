using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[Personal]")]
[DisplayName("Personal"), InstanceName("Personal")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class PersonalRow : Row<PersonalRow.RowFields>, IIdRow, INameRow
{
    const string jDepartment = nameof(jDepartment);
    const string jBranch = nameof(jBranch);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("First Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string FirstName
    {
        get => fields.FirstName[this];
        set => fields.FirstName[this] = value;
    }

    [DisplayName("Last Name"), Size(100), NotNull]
    public string LastName
    {
        get => fields.LastName[this];
        set => fields.LastName[this] = value;
    }

    [DisplayName("Middle Name"), Size(100)]
    public string MiddleName
    {
        get => fields.MiddleName[this];
        set => fields.MiddleName[this] = value;
    }

    [DisplayName("Email"), Size(250), NotNull]
    public string Email
    {
        get => fields.Email[this];
        set => fields.Email[this] = value;
    }

    [DisplayName("Mobile Number"), Column("Mobile number"), NotNull]
    public int? MobileNumber
    {
        get => fields.MobileNumber[this];
        set => fields.MobileNumber[this] = value;
    }

    [DisplayName("Pnr"), Column("PNR"), Size(50)]
    public string Pnr
    {
        get => fields.Pnr[this];
        set => fields.Pnr[this] = value;
    }

    [DisplayName("Permanent Address"), Column("Permanent address"), Size(300), NotNull]
    public string PermanentAddress
    {
        get => fields.PermanentAddress[this];
        set => fields.PermanentAddress[this] = value;
    }

    [DisplayName("City"), Size(50), NotNull]
    public string City
    {
        get => fields.City[this];
        set => fields.City[this] = value;
    }

    [DisplayName("Pin"), Column("PIN"), NotNull]
    public int? Pin
    {
        get => fields.Pin[this];
        set => fields.Pin[this] = value;
    }

    [DisplayName("Current Address"), Column("Current address"), Size(200), NotNull]
    public string CurrentAddress
    {
        get => fields.CurrentAddress[this];
        set => fields.CurrentAddress[this] = value;
    }

    [DisplayName("Current City"), Column("Current_City"), Size(50), NotNull]
    public string CurrentCity
    {
        get => fields.CurrentCity[this];
        set => fields.CurrentCity[this] = value;
    }

    [DisplayName("Gender"), Size(50), NotNull]
    public string Gender
    {
        get => fields.Gender[this];
        set => fields.Gender[this] = value;
    }

    [DisplayName("Dob"), Column("DOB"), NotNull]
    public DateTime? Dob
    {
        get => fields.Dob[this];
        set => fields.Dob[this] = value;
    }

    [DisplayName("Admission Date"), NotNull]
    public DateTime? AdmissionDate
    {
        get => fields.AdmissionDate[this];
        set => fields.AdmissionDate[this] = value;
    }

    [DisplayName("Department"), Column("Department_Id"), ForeignKey("[organisation].[Departments]", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    public int? DepartmentId
    {
        get => fields.DepartmentId[this];
        set => fields.DepartmentId[this] = value;
    }

    [DisplayName("Branch"), Column("Branch_Id"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
    public int? BranchId
    {
        get => fields.BranchId[this];
        set => fields.BranchId[this] = value;
    }

    [DisplayName("Department Department Name"), Expression($"{jDepartment}.[Department Name]")]
    public string DepartmentName
    {
        get => fields.DepartmentName[this];
        set => fields.DepartmentName[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField FirstName;
        public StringField LastName;
        public StringField MiddleName;
        public StringField Email;
        public Int32Field MobileNumber;
        public StringField Pnr;
        public StringField PermanentAddress;
        public StringField City;
        public Int32Field Pin;
        public StringField CurrentAddress;
        public StringField CurrentCity;
        public StringField Gender;
        public DateTimeField Dob;
        public DateTimeField AdmissionDate;
        public Int32Field DepartmentId;
        public Int32Field BranchId;

        public StringField DepartmentName;
        public StringField BranchName;
    }
}