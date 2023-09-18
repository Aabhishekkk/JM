using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Organisation.Forms
{
    [FormScript("Division.DivisionExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class DivisionExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}