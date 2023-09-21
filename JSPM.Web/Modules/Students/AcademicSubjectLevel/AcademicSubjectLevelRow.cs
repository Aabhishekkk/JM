using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[AcademicSubjectLevel]")]
[DisplayName("Academic Subject Level"), InstanceName("Academic Subject Level")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class AcademicSubjectLevelRow : Row<AcademicSubjectLevelRow.RowFields>, IIdRow, INameRow
{
    const string jBranch = nameof(jBranch);
    const string jAcademicYear = nameof(jAcademicYear);
    const string jSemester = nameof(jSemester);
    const string jDivision = nameof(jDivision);
    const string jSubject = nameof(jSubject);
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Branch"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
    public int? BranchId
    {
        get => fields.BranchId[this];
        set => fields.BranchId[this] = value;
    }

    [DisplayName("Academic Year"), ForeignKey("[organisation].[AcademicYears ]", "Id"), LeftJoin(jAcademicYear)]
    public int? AcademicYearId
    {
        get => fields.AcademicYearId[this];
        set => fields.AcademicYearId[this] = value;
    }

    [DisplayName("Semester"), ForeignKey("[organisation].[Semesters ]", "Id"), LeftJoin(jSemester)]
    public int? SemesterId
    {
        get => fields.SemesterId[this];
        set => fields.SemesterId[this] = value;
    }

    [DisplayName("Division"), ForeignKey("[organisation].[Division]", "Id"), LeftJoin(jDivision), TextualField(nameof(DivisionName))]
    public int? DivisionId
    {
        get => fields.DivisionId[this];
        set => fields.DivisionId[this] = value;
    }

    [DisplayName("Subject"), ForeignKey("[dbo].[Subjects]", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectName))]
    public int? SubjectId
    {
        get => fields.SubjectId[this];
        set => fields.SubjectId[this] = value;
    }

    [DisplayName("Month"), NotNull]
    public int? Month
    {
        get => fields.Month[this];
        set => fields.Month[this] = value;
    }

    [DisplayName("Year"), NotNull]
    public int? Year
    {
        get => fields.Year[this];
        set => fields.Year[this] = value;
    }

    [DisplayName("E Status"), Column("eStatus"), Size(255), NotNull, QuickSearch, NameProperty]
    public string EStatus
    {
        get => fields.EStatus[this];
        set => fields.EStatus[this] = value;
    }

    [DisplayName("Grade"), Size(50), NotNull]
    public string Grade
    {
        get => fields.Grade[this];
        set => fields.Grade[this] = value;
    }

    [DisplayName("Percentage"), Size(19), Scale(5), NotNull]
    public decimal? Percentage
    {
        get => fields.Percentage[this];
        set => fields.Percentage[this] = value;
    }

    [DisplayName("Student"), ForeignKey("[Students].[Personal]", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentFirstName))]
    public int? StudentId
    {
        get => fields.StudentId[this];
        set => fields.StudentId[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    [DisplayName("Division Division Name"), Expression($"{jDivision}.[Division Name]")]
    public string DivisionName
    {
        get => fields.DivisionName[this];
        set => fields.DivisionName[this] = value;
    }

    [DisplayName("Subject Subject Name"), Expression($"{jSubject}.[Subject Name]")]
    public string SubjectName
    {
        get => fields.SubjectName[this];
        set => fields.SubjectName[this] = value;
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
        public Int32Field BranchId;
        public Int32Field AcademicYearId;
        public Int32Field SemesterId;
        public Int32Field DivisionId;
        public Int32Field SubjectId;
        public Int32Field Month;
        public Int32Field Year;
        public StringField EStatus;
        public StringField Grade;
        public DecimalField Percentage;
        public Int32Field StudentId;

        public StringField BranchName;
        public StringField DivisionName;
        public StringField SubjectName;
        public StringField StudentFirstName;
    }
}