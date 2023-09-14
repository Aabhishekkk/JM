using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Branches]")]
[DisplayName("Branches"), InstanceName("Branches")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class BranchesRow : Row<BranchesRow.RowFields>, IIdRow, INameRow
{
    const string jInstitute = nameof(jInstitute);
    const string jDepartment = nameof(jDepartment);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Branch Name"), Column("Branch Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    [DisplayName("Branch Code"), Column("Branch Code"), Size(50), NotNull]
    public string BranchCode
    {
        get => fields.BranchCode[this];
        set => fields.BranchCode[this] = value;
    }

    [DisplayName("Institute"), Column("Institute_Id"), ForeignKey("[organisation].[Institute]", "Id"), LeftJoin(jInstitute), TextualField(nameof(InstituteName))]
    public int? InstituteId
    {
        get => fields.InstituteId[this];
        set => fields.InstituteId[this] = value;
    }

    [DisplayName("Department"), Column("Department_Id"), ForeignKey("[organisation].[Departments]", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    public int? DepartmentId
    {
        get => fields.DepartmentId[this];
        set => fields.DepartmentId[this] = value;
    }

    [DisplayName("Institute Institute Name"), Expression($"{jInstitute}.[Institute Name]")]
    public string InstituteName
    {
        get => fields.InstituteName[this];
        set => fields.InstituteName[this] = value;
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
        public StringField BranchName;
        public StringField BranchCode;
        public Int32Field InstituteId;
        public Int32Field DepartmentId;

        public StringField InstituteName;
        public StringField DepartmentName;
    }
}