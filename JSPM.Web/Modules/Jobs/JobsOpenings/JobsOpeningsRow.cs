using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace JSPM.Jobs;

[ConnectionKey("Default"), Module("Jobs"), TableName("[Jobs].[JobsOpenings]")]
[DisplayName("Jobs Openings"), InstanceName("Jobs Openings")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class JobsOpeningsRow : Row<JobsOpeningsRow.RowFields>, IIdRow, INameRow
{
    const string jSkills = nameof(jSkills);

    [DisplayName("Id"), Identity, IdProperty]
    [SortOrder(1, descending: false)]
    public int? Id
    {
        get => fields.Id[this];
        set => fields.Id[this] = value;
    }

    [DisplayName("Type Of Employement"), Column("Type of Employement"), Size(200), NotNull, QuickSearch, NameProperty]
    public string TypeOfEmployement
    {
        get => fields.TypeOfEmployement[this];
        set => fields.TypeOfEmployement[this] = value;
    }

    [DisplayName("Description"), Size(1000), NotNull]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Levels"), Size(100)]
    public string Levels
    {
        get => fields.Levels[this];
        set => fields.Levels[this] = value;
    }

    [DisplayName("Vacancy")]
    public int? Vacancy
    {
        get => fields.Vacancy[this];
        set => fields.Vacancy[this] = value;
    }

    [DisplayName("Company Name"), Size(500), NotNull]
    public string CompanyName
    {
        get => fields.CompanyName[this];
        set => fields.CompanyName[this] = value;
    }

    [DisplayName("Location"), Size(1000), NotNull]
    public string Location
    {
        get => fields.Location[this];
        set => fields.Location[this] = value;
    }

    [DisplayName("Role"), Size(100)]
    public string Role
    {
        get => fields.Role[this];
        set => fields.Role[this] = value;
    }

    [DisplayName("Budget"), Size(500), NotNull]
    public string Budget
    {
        get => fields.Budget[this];
        set => fields.Budget[this] = value;
    }

    [DisplayName("Shift"), Size(100), NotNull]
    public string Shift
    {
        get => fields.Shift[this];
        set => fields.Shift[this] = value;
    }

    [DisplayName("Skills"), Size(1000), NotNull]
    public string Skills
    {
        get => fields.Skills[this];
        set => fields.Skills[this] = value;
    }

    [DisplayName("Skills"), ForeignKey("[Students].[StudentsSkills]", "Id"), LeftJoin(jSkills), TextualField(nameof(SkillsSkillCategory))]
    public int? SkillsId
    {
        get => fields.SkillsId[this];
        set => fields.SkillsId[this] = value;
    }

    [DisplayName("Skills Skill Category"), Expression($"{jSkills}.[SkillCategory]")]
    public string SkillsSkillCategory
    {
        get => fields.SkillsSkillCategory[this];
        set => fields.SkillsSkillCategory[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField TypeOfEmployement;
        public StringField Description;
        public StringField Levels;
        public Int32Field Vacancy;
        public StringField CompanyName;
        public StringField Location;
        public StringField Role;
        public StringField Budget;
        public StringField Shift;
        public StringField Skills;
        public Int32Field SkillsId;

        public StringField SkillsSkillCategory;
    }
}