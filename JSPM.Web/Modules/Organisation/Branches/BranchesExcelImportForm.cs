

    using Serenity.ComponentModel;
    using Serenity.Data.Mapping;
    using Serenity.Web;
    using System;
    using System.ComponentModel;
//namespace JSPM.Web.Modules.Organisation.Branches.Forms
namespace JSPM.Organisation.Branches.Forms
{
    [FormScript("Branches.BrachesExcelImport")]
    // [BasedOnRow(typeof(QuestionRow), CheckNames = true)]
    public class BranchesExcelImportForm
    {
        [FileUploadEditor, Required]
        public String FileName { get; set; }
    }
}
    
