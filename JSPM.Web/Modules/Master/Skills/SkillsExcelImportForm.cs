using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Skills.Forms
{
    [FormScript("Master.SkillsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class SkillsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}