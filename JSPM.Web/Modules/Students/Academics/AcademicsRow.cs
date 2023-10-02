using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[Academics]")]
[DisplayName("Academics"), InstanceName("Academics")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class AcademicsRow : Row<AcademicsRow.RowFields>, IIdRow, INameRow
{
    const string jProject = nameof(jProject);
    const string jStudent = nameof(jStudent);
    const string jSkill = nameof(jSkill);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Course Level"), Size(50), QuickSearch, NameProperty]
    public string CourseLevel
    {
        get => fields.CourseLevel[this];
        set => fields.CourseLevel[this] = value;
    }

    [DisplayName("Course Name"), Size(50)]
    public string CourseName
    {
        get => fields.CourseName[this];
        set => fields.CourseName[this] = value;
    }

    [DisplayName("Year Of Passing"), Size(50)]
    public string YearOfPassing
    {
        get => fields.YearOfPassing[this];
        set => fields.YearOfPassing[this] = value;
    }

    [DisplayName("Percentage"), Size(50)]
    public string Percentage
    {
        get => fields.Percentage[this];
        set => fields.Percentage[this] = value;
    }

    [DisplayName("Remark"), Size(50)]
    public string Remark
    {
        get => fields.Remark[this];
        set => fields.Remark[this] = value;
    }

    [DisplayName("Passing Type"), Size(50)]
    public string PassingType
    {
        get => fields.PassingType[this];
        set => fields.PassingType[this] = value;
    }

    [DisplayName("Project"), ForeignKey("[Students].[Project]", "Id"), LeftJoin(jProject), TextualField(nameof(ProjectType))]
    public int? ProjectId
    {
        get => fields.ProjectId[this];
        set => fields.ProjectId[this] = value;
    }

    [DisplayName("Student"), ForeignKey("[Students].[Personal]", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentFirstName))]
    public int? StudentId
    {
        get => fields.StudentId[this];
        set => fields.StudentId[this] = value;
    }

    [DisplayName("Skill"), ForeignKey("[Students].[StudentsSkills]", "Id"), LeftJoin(jSkill), TextualField(nameof(SkillCategory))]
    public int? SkillId
    {
        get => fields.SkillId[this];
        set => fields.SkillId[this] = value;
    }

    [DisplayName("Project Type"), Expression($"{jProject}.[Type]")]
    public string ProjectType
    {
        get => fields.ProjectType[this];
        set => fields.ProjectType[this] = value;
    }

    [DisplayName("Student First Name"), Expression($"{jStudent}.[FirstName]")]
    public string StudentFirstName
    {
        get => fields.StudentFirstName[this];
        set => fields.StudentFirstName[this] = value;
    }

    [DisplayName("Skill Skill Category"), Expression($"{jSkill}.[SkillCategory]")]
    public string SkillCategory
    {
        get => fields.SkillCategory[this];
        set => fields.SkillCategory[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField CourseLevel;
        public StringField CourseName;
        public StringField YearOfPassing;
        public StringField Percentage;
        public StringField Remark;
        public StringField PassingType;
        public Int32Field ProjectId;
        public Int32Field StudentId;
        public Int32Field SkillId;

        public StringField ProjectType;
        public StringField StudentFirstName;
        public StringField SkillCategory;
    }
}