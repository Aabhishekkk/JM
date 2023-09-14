using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("[Syllabus].[Topics]")]
[DisplayName("Topics"), InstanceName("Topics")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TopicsRow : Row<TopicsRow.RowFields>, IIdRow, INameRow
{
    const string jSubject = nameof(jSubject);
    const string jChapter = nameof(jChapter);

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

    [DisplayName("Chapter"), ForeignKey("[Syllabus].[Chapters]", "Id"), LeftJoin(jChapter), TextualField(nameof(ChapterName))]
    public int? ChapterId
    {
        get => fields.ChapterId[this];
        set => fields.ChapterId[this] = value;
    }

    [DisplayName("Topic Name"), Size(100), NotNull, QuickSearch, NameProperty]
    public string TopicName
    {
        get => fields.TopicName[this];
        set => fields.TopicName[this] = value;
    }

    [DisplayName("Description"), Size(1000)]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Index"), NotNull]
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

    [DisplayName("Chapter Chapter Name"), Expression($"{jChapter}.[ChapterName]")]
    public string ChapterName
    {
        get => fields.ChapterName[this];
        set => fields.ChapterName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field SubjectId;
        public Int32Field ChapterId;
        public StringField TopicName;
        public StringField Description;
        public Int32Field Index;

        public StringField SubjectName;
        public StringField ChapterName;
    }
}