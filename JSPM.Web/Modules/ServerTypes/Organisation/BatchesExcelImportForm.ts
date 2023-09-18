import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface BatchesExcelImportForm {
    FileName: ImageUploadEditor;
}

export class BatchesExcelImportForm extends PrefixedContext {
    static formKey = 'Organisation.BatchesExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BatchesExcelImportForm.init)  {
            BatchesExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(BatchesExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}