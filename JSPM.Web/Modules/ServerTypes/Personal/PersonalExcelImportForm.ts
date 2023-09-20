import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface PersonalExcelImportForm {
    FileName: ImageUploadEditor;
}

export class PersonalExcelImportForm extends PrefixedContext {
    static formKey = 'Personal.PersonalExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonalExcelImportForm.init)  {
            PersonalExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(PersonalExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}