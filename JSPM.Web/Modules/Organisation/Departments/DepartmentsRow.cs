using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Departments]")]
[DisplayName("Departments"), InstanceName("Departments")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class DepartmentsRow : Row<DepartmentsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Department Name"), Column("Department Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string DepartmentName
    {
        get => fields.DepartmentName[this];
        set => fields.DepartmentName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField DepartmentName;

    }
}