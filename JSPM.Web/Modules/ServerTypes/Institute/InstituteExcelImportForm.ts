import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface InstituteExcelImportForm {
    FileName: ImageUploadEditor;
}

export class InstituteExcelImportForm extends PrefixedContext {
    static formKey = 'Institute.InstituteExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteExcelImportForm.init)  {
            InstituteExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(InstituteExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}