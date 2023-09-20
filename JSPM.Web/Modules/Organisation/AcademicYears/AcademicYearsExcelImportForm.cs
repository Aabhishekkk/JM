using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Organisation.Forms
{
    [FormScript("AcademicYears.AcademicYearsExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class AcademicYearsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
