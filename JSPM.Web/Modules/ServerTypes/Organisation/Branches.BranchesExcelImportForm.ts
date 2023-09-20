import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface BranchesExcelImportForm {
    FileName: ImageUploadEditor;
}

export class BranchesExcelImportForm extends PrefixedContext {
    static formKey = 'Branches.BrachesExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BranchesExcelImportForm.init)  {
            BranchesExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(BranchesExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}