using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[Project]")]
[DisplayName("Project"), InstanceName("Project")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class ProjectRow : Row<ProjectRow.RowFields>, IIdRow, INameRow
{
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Student"), ForeignKey("[Students].[Personal]", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentFirstName))]
    public int? StudentId
    {
        get => fields.StudentId[this];
        set => fields.StudentId[this] = value;
    }

    [DisplayName("Type"), Size(100), NotNull, QuickSearch, NameProperty]
    public string Type
    {
        get => fields.Type[this];
        set => fields.Type[this] = value;
    }

    [DisplayName("Project Title"), Size(100)]
    public string ProjectTitle
    {
        get => fields.ProjectTitle[this];
        set => fields.ProjectTitle[this] = value;
    }

    [DisplayName("Project Details"), Size(1000)]
    public string ProjectDetails
    {
        get => fields.ProjectDetails[this];
        set => fields.ProjectDetails[this] = value;
    }

    [DisplayName("Project Report"), Size(500)]
    public string ProjectReport
    {
        get => fields.ProjectReport[this];
        set => fields.ProjectReport[this] = value;
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
        public Int32Field StudentId;
        public StringField Type;
        public StringField ProjectTitle;
        public StringField ProjectDetails;
        public StringField ProjectReport;

        public StringField StudentFirstName;
    }
}