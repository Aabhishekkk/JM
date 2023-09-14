import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface InstituteForm {
    InstituteName: StringEditor;
    Description: StringEditor;
}

export class InstituteForm extends PrefixedContext {
    static formKey = 'Organisation.Institute';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteForm.init)  {
            InstituteForm.init = true;

            var w0 = StringEditor;

            initFormType(InstituteForm, [
                'InstituteName', w0,
                'Description', w0
            ]);
        }
    }
}