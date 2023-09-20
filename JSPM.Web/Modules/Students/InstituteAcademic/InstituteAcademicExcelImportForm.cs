
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.InstituteAcademic
{
    [FormScript("InstituteAcademic.ProjectExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class InstituteAcademicExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}