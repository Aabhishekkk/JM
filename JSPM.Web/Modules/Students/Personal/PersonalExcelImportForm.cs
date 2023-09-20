
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Personal
{
    [FormScript("Personal.PersonalExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class PersonalExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}