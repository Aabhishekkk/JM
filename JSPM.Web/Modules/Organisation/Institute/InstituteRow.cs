using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Institute]")]
[DisplayName("Institute"), InstanceName("Institute")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class InstituteRow : Row<InstituteRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Institute Name"), Column("Institute Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string InstituteName
    {
        get => fields.InstituteName[this];
        set => fields.InstituteName[this] = value;
    }

    [DisplayName("Description"), Size(1000)]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField InstituteName;
        public StringField Description;

    }
}