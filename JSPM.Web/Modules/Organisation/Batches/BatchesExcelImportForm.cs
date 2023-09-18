using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Organisation.Forms
{
    [FormScript("Organisation.BatchesExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class BatchesExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
