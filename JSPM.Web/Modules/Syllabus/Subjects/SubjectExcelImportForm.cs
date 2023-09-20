using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;

namespace JSPM.Modules.Syllabus.Subjects

{
    [FormScript("Syllabus.SubjectExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class SubjectExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}