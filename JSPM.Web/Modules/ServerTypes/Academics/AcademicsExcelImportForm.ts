import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class AcademicsExcelImportForm extends PrefixedContext {
    static formKey = 'Academics.AcademicsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicsExcelImportForm.init)  {
            AcademicsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(AcademicsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}