using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Examination.Forms
{
    [FormScript("JSPM.ExamAttemptDetailsExcel")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class ExamAttemptDetailsExcelForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
