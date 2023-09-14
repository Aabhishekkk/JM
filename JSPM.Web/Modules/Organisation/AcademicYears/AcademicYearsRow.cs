using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[AcademicYears ]")]
[DisplayName("Academic Years"), InstanceName("Academic Years")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class AcademicYearsRow : Row<AcademicYearsRow.RowFields>, IIdRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Academic Year"), Column("Academic Year"), NotNull]
    public int? AcademicYear
    {
        get => fields.AcademicYear[this];
        set => fields.AcademicYear[this] = value;
    }

    [DisplayName("Index")]
    public int? Index
    {
        get => fields.Index[this];
        set => fields.Index[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field AcademicYear;
        public Int32Field Index;

    }
}