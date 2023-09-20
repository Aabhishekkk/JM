using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Organisation.Forms
{
    [FormScript("Syllabus.SubjectExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class SemestersImportExcelForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
