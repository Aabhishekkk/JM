import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicYearsForm {
    AcademicYear: StringEditor;
    Index: IntegerEditor;
}

export class AcademicYearsForm extends PrefixedContext {
    static formKey = 'Organisation.AcademicYears';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicYearsForm.init)  {
            AcademicYearsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(AcademicYearsForm, [
                'AcademicYear', w0,
                'Index', w1
            ]);
        }
    }
}