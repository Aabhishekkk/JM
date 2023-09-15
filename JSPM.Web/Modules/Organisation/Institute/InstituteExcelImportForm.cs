
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Institute
{
    [FormScript("Institute.InstituteExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class InstituteExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}