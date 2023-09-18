using Serenity.ComponentModel;
using Serenity.Data.Mapping;
using Serenity.Web;
using System;
using System.ComponentModel;
namespace JSPM.Departments.Forms
{
    [FormScript("Syllabus.SubjectExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class DepartmentsExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}