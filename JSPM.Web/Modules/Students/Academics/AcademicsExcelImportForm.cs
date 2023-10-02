
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Academics
{
    [FormScript("Academics.AcademicsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class AcademicsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}