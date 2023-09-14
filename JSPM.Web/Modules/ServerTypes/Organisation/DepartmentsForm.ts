import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DepartmentsForm {
    DepartmentName: StringEditor;
}

export class DepartmentsForm extends PrefixedContext {
    static formKey = 'Organisation.Departments';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DepartmentsForm.init)  {
            DepartmentsForm.init = true;

            var w0 = StringEditor;

            initFormType(DepartmentsForm, [
                'DepartmentName', w0
            ]);
        }
    }
}