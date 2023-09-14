using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Batches]")]
[DisplayName("Batches"), InstanceName("Batches")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class BatchesRow : Row<BatchesRow.RowFields>, IIdRow, INameRow
{
    const string jDivision = nameof(jDivision);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Division"), ForeignKey("[organisation].[Division]", "Id"), LeftJoin(jDivision), TextualField(nameof(DivisionName))]
    public int? DivisionId
    {
        get => fields.DivisionId[this];
        set => fields.DivisionId[this] = value;
    }

    [DisplayName("Batch Name"), Column("Batch Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string BatchName
    {
        get => fields.BatchName[this];
        set => fields.BatchName[this] = value;
    }

    [DisplayName("Division Division Name"), Expression($"{jDivision}.[Division Name]")]
    public string DivisionName
    {
        get => fields.DivisionName[this];
        set => fields.DivisionName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field DivisionId;
        public StringField BatchName;

        public StringField DivisionName;
    }
}