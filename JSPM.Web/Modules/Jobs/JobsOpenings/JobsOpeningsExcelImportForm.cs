using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.JobsOpenings
{
    [FormScript("JobsOpenings.JobsOpeningsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class JobsOpeningsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}