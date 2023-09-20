using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;

namespace JSPM.Modules.Syllabus

{
    [FormScript("Syllabus.ChaptersExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class ChaptersExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}