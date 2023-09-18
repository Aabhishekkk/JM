import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DivisionExcelImportForm {
    FileName: ImageUploadEditor;
}

export class DivisionExcelImportForm extends PrefixedContext {
    static formKey = 'Division.DivisionExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DivisionExcelImportForm.init)  {
            DivisionExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(DivisionExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}