import { IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SemestersForm {
    Semester: IntegerEditor;
    AcademicYearsId: IntegerEditor;
    Index: IntegerEditor;
}

export class SemestersForm extends PrefixedContext {
    static formKey = 'Organisation.Semesters';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SemestersForm.init)  {
            SemestersForm.init = true;

            var w0 = IntegerEditor;

            initFormType(SemestersForm, [
                'Semester', w0,
                'AcademicYearsId', w0,
                'Index', w0
            ]);
        }
    }
}