using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[TeacherEndorsement]")]
[DisplayName("Teacher Endorsement"), InstanceName("Teacher Endorsement")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class TeacherEndorsementRow : Row<TeacherEndorsementRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    [SortOrder(1, descending: false)]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Teacher Id")]
    public string TeacherId
    {
        get => fields.TeacherId[this];
        set => fields.TeacherId[this] = value;
    }

    [DisplayName("Student"), ForeignKey("[Students].[Personal]", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentFirstName))]
    public int? StudentId
    {
        get => fields.StudentId[this];
        set => fields.StudentId[this] = value;
    }

    [DisplayName("Title"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Title
    {
        get => fields.Title[this];
        set => fields.Title[this] = value;
    }

    [DisplayName("Details"), Size(500), NotNull]
    public string Details
    {
        get => fields.Details[this];
        set => fields.Details[this] = value;
    }

    [DisplayName("Student First Name"), Expression($"{jStudent}.[FirstName]")]
    public string StudentFirstName
    {
        get => fields.StudentFirstName[this];
        set => fields.StudentFirstName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField TeacherId;
        public Int32Field StudentId;
        public StringField Title;
        public StringField Details;

        public StringField StudentFirstName;
    }
}