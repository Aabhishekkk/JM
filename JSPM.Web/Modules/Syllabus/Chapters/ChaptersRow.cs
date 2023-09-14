using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("[Syllabus].[Chapters]")]
[DisplayName("Chapters"), InstanceName("Chapters")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ChaptersRow : Row<ChaptersRow.RowFields>, IIdRow, INameRow
{
    const string jSubject = nameof(jSubject);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Subject"), ForeignKey("[Syllabus].[Subjects]", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectName))]
    public int? SubjectId
    {
        get => fields.SubjectId[this];
        set => fields.SubjectId[this] = value;
    }

    [DisplayName("Chapter Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string ChapterName
    {
        get => fields.ChapterName[this];
        set => fields.ChapterName[this] = value;
    }

    [DisplayName("Description"), Size(1000)]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Index")]
    public int? Index
    {
        get => fields.Index[this];
        set => fields.Index[this] = value;
    }

    [DisplayName("Subject Subject Name"), Expression($"{jSubject}.[Subject Name]")]
    public string SubjectName
    {
        get => fields.SubjectName[this];
        set => fields.SubjectName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field SubjectId;
        public StringField ChapterName;
        public StringField Description;
        public Int32Field Index;

        public StringField SubjectName;
    }
}