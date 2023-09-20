
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.TeacherEndorsement
{
    [FormScript("TeacherEndorsement.TeacherEndorsementExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class TeacherEndorsementExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}