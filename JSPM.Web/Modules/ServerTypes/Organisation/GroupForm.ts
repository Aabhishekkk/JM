import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface GroupForm {
    BatchId: IntegerEditor;
    GroupName: StringEditor;
}

export class GroupForm extends PrefixedContext {
    static formKey = 'Organisation.Group';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GroupForm.init)  {
            GroupForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(GroupForm, [
                'BatchId', w0,
                'GroupName', w1
            ]);
        }
    }
}