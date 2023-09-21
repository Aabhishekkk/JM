using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Students;

[ConnectionKey("Default"), Module("Students"), TableName("[Students].[StudentsSkills]")]
[DisplayName("Students Skills"), InstanceName("Students Skills")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class StudentsSkillsRow : Row<StudentsSkillsRow.RowFields>, IIdRow, INameRow
{
    const string jSkill = nameof(jSkill);
    const string jStudent = nameof(jStudent);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Skill Category"), Size(50), NotNull, QuickSearch, NameProperty]
    public string SkillCategory
    {
        get => fields.SkillCategory[this];
        set => fields.SkillCategory[this] = value;
    }

    [DisplayName("Skill"), Column("SkillId"), ForeignKey("[Master].[Skills]", "Id"), LeftJoin(jSkill), TextualField(nameof(SkillName))]
    public int? SkillId
    {
        get => fields.SkillId[this];
        set => fields.SkillId[this] = value;
    }

    [DisplayName("Rating"), NotNull]
    public int? Rating
    {
        get => fields.Rating[this];
        set => fields.Rating[this] = value;
    }

    [DisplayName("Aknowledge By"), Size(50), NotNull]
    public string AknowledgeBy
    {
        get => fields.AknowledgeBy[this];
        set => fields.AknowledgeBy[this] = value;
    }

    [DisplayName("Certification"), Size(50), NotNull]
    public string Certification
    {
        get => fields.Certification[this];
        set => fields.Certification[this] = value;
    }

    [DisplayName("Certification Details"), Column("Certification details"), Size(50), NotNull]
    public string CertificationDetails
    {
        get => fields.CertificationDetails[this];
        set => fields.CertificationDetails[this] = value;
    }

    [DisplayName("Student"), ForeignKey("[Students].[Personal]", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentFirstName))]
    public int? StudentId
    {
        get => fields.StudentId[this];
        set => fields.StudentId[this] = value;
    }

   

    [DisplayName("Skill Name"), Expression($"{jSkill}.[Name]")]
    public string SkillName
    {
        get => fields.SkillName[this];
        set => fields.SkillName[this] = value;
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
        public StringField SkillCategory;
        public Int32Field SkillId;
        public Int32Field Rating;
        public StringField AknowledgeBy;
        public StringField Certification;
        public StringField CertificationDetails;
        public Int32Field StudentId;
       

        public StringField SkillName;
        public StringField StudentFirstName;
    }
}