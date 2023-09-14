import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface BatchesForm {
    DivisionId: IntegerEditor;
    BatchName: StringEditor;
}

export class BatchesForm extends PrefixedContext {
    static formKey = 'Organisation.Batches';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BatchesForm.init)  {
            BatchesForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(BatchesForm, [
                'DivisionId', w0,
                'BatchName', w1
            ]);
        }
    }
}