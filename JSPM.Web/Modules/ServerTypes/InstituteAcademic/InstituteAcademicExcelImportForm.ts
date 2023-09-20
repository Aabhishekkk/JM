import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface InstituteAcademicExcelImportForm {
    FileName: ImageUploadEditor;
}

export class InstituteAcademicExcelImportForm extends PrefixedContext {
    static formKey = 'InstituteAcademic.ProjectExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteAcademicExcelImportForm.init)  {
            InstituteAcademicExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(InstituteAcademicExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}