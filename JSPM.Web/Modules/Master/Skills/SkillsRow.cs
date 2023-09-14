using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Master;

[ConnectionKey("Default"), Module("Master"), TableName("[Master].[Skills]")]
[DisplayName("Skills"), InstanceName("Skills")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class SkillsRow : Row<SkillsRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;

    }
}