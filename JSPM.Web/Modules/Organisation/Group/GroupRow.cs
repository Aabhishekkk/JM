using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Group]")]
[DisplayName("Group"), InstanceName("Group")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class GroupRow : Row<GroupRow.RowFields>, IIdRow, INameRow
{
    const string jBatch = nameof(jBatch);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Batch"), Column("Batch Id"), ForeignKey("[organisation].[Batches]", "Id"), LeftJoin(jBatch), TextualField(nameof(BatchName))]
    public int? BatchId
    {
        get => fields.BatchId[this];
        set => fields.BatchId[this] = value;
    }

    [DisplayName("Group Name"), Column("Group Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string GroupName
    {
        get => fields.GroupName[this];
        set => fields.GroupName[this] = value;
    }

    [DisplayName("Batch Batch Name"), Expression($"{jBatch}.[Batch Name]")]
    public string BatchName
    {
        get => fields.BatchName[this];
        set => fields.BatchName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field BatchId;
        public StringField GroupName;

        public StringField BatchName;
    }
}