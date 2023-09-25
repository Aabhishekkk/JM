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
    const string jDepartment = nameof(jDepartment);
    const string jSemester = nameof(jSemester);

    [DisplayName("Id"), Identity, IdProperty]
    [SortOrder(1, descending: false)]
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
    [DisplayName("Department"), Column("DepartmentId"), ForeignKey("[organisation].[Departments]", "Id"), LeftJoin(jDepartment), TextualField(nameof(DepartmentName))]
    public int? DepartmentId
    {
        get => fields.DepartmentId[this];
        set => fields.DepartmentId[this] = value;

    }
    [DisplayName("Department Department Name"), Expression($"{jDepartment}.[Department Name]")]
    public string DepartmentName
    {
        get => fields.DepartmentName[this];
        set => fields.DepartmentName[this] = value;
    }
    [DisplayName("Semester"), Column("SemesterId"), ForeignKey("[organisation].[Semesters]", "Id"), LeftJoin(jSemester), TextualField(nameof(SemesterName))]
    public int? SemesterId
    {
        get => fields.SemesterId[this];
        set => fields.SemesterId[this] = value;

    
}
[DisplayName("Semester Semester Name"), Expression($"{jSemester}.[Semester]")]
public string SemesterName
    {
    get => fields.SemesterName[this];
    set => fields.SemesterName[this] = value;
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
        public Int32Field DepartmentId;
        public StringField DepartmentName;
        public Int32Field SemesterId;
        public StringField SemesterName;
    }
}