
using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM. Project
{
    [FormScript("Project.ProjectExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class JobOpeningExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}