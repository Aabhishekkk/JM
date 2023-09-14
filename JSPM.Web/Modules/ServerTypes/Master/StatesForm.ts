import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface StatesForm {
    Name: StringEditor;
}

export class StatesForm extends PrefixedContext {
    static formKey = 'Master.States';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StatesForm.init)  {
            StatesForm.init = true;

            var w0 = StringEditor;

            initFormType(StatesForm, [
                'Name', w0
            ]);
        }
    }
}