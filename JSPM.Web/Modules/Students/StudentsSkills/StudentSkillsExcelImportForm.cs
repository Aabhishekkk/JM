using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.StudentSkills
{
    [FormScript("StudentSkills.StudentSkillsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class StudentSkillsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}