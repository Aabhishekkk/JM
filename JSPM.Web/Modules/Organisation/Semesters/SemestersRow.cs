using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace JSPM.Organisation;

[ConnectionKey("Default"), Module("Organisation"), TableName("[organisation].[Semesters ]")]
[DisplayName("Semesters"), InstanceName("Semesters")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class SemestersRow : Row<SemestersRow.RowFields>, IIdRow
{
    const string jAcademicYears = nameof(jAcademicYears);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Semester"), NotNull]
    public String Semester
    {
        get => fields.Semester[this];
        set => fields.Semester[this] = value;
    }

    [DisplayName("Academic Years"), Column("AcademicYears_Id"), ForeignKey("[organisation].[AcademicYears ]", "Id"), LeftJoin(jAcademicYears)]
    public int? AcademicYearsId
    {
        get => fields.AcademicYearsId[this];
        set => fields.AcademicYearsId[this] = value;
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
        public StringField Semester;
        public Int32Field AcademicYearsId;
        public Int32Field Index;

    }
}