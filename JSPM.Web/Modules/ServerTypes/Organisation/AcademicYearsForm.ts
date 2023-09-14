import { IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicYearsForm {
    AcademicYear: IntegerEditor;
    Index: IntegerEditor;
}

export class AcademicYearsForm extends PrefixedContext {
    static formKey = 'Organisation.AcademicYears';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicYearsForm.init)  {
            AcademicYearsForm.init = true;

            var w0 = IntegerEditor;

            initFormType(AcademicYearsForm, [
                'AcademicYear', w0,
                'Index', w0
            ]);
        }
    }
}