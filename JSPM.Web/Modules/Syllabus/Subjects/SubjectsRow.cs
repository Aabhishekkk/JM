using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("[dbo].[Subjects]")]
[DisplayName("Subjects"), InstanceName("Subjects")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class SubjectsRow : Row<SubjectsRow.RowFields>, IIdRow, INameRow
{
    const string jBranch = nameof(jBranch);
    const string jAcademicYear = nameof(jAcademicYear);
    const string jSemester = nameof(jSemester);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Subject Name"), Column("Subject Name"), Size(200), NotNull, QuickSearch, NameProperty]
    public string SubjectName
    {
        get => fields.SubjectName[this];
        set => fields.SubjectName[this] = value;
    }

    [DisplayName("Branch"), Column("Branch_Id"), ForeignKey("[organisation].[Branches]", "Id"), LeftJoin(jBranch), TextualField(nameof(BranchName))]
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

    [DisplayName("Priority"), Size(50)]
    public short? Priority
    {
        get => fields.Priority[this];
        set => fields.Priority[this] = value;
    }

    [DisplayName("Branch Branch Name"), Expression($"{jBranch}.[Branch Name]")]
    public string BranchName
    {
        get => fields.BranchName[this];
        set => fields.BranchName[this] = value;
    }

    [DisplayName("Subject Code")]
    public string SubjectCode
    {
        get => fields.SubjectCode[this];
        set => fields.SubjectCode[this] = value;
    }
    
    [DisplayName("Description") ]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }
    [DisplayName("SubjectType") ]
    public string SubjectType
    {
        get => fields.SubjectType[this];
        set => fields.SubjectType[this] = value;
    }


    
    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField SubjectName;
        public Int32Field BranchId;
        public Int32Field AcademicYearId;
        public Int32Field SemesterId;
        public Int16Field Priority;
        public StringField BranchName;
        public StringField SubjectCode;
        public StringField Description;
        public StringField SubjectType;
       
    }
}