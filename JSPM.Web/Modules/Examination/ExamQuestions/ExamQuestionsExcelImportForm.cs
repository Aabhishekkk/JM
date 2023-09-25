using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Examination.Forms
{
    [FormScript("Examination.ExamQuestionsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class ExamQuestionsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}