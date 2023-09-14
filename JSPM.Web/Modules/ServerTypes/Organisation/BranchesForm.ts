import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface BranchesForm {
    BranchName: StringEditor;
    BranchCode: StringEditor;
    InstituteId: IntegerEditor;
    DepartmentId: IntegerEditor;
}

export class BranchesForm extends PrefixedContext {
    static formKey = 'Organisation.Branches';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!BranchesForm.init)  {
            BranchesForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(BranchesForm, [
                'BranchName', w0,
                'BranchCode', w0,
                'InstituteId', w1,
                'DepartmentId', w1
            ]);
        }
    }
}