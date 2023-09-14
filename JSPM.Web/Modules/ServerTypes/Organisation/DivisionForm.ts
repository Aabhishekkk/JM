import { IntegerEditor, DateEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DivisionForm {
    InstituteId: IntegerEditor;
    BranchId: IntegerEditor;
    DepartmentId: IntegerEditor;
    AcademicYearsId: IntegerEditor;
    SemesterId: IntegerEditor;
    StartDate: DateEditor;
    EndDate: DateEditor;
    DivisionName: StringEditor;
}

export class DivisionForm extends PrefixedContext {
    static formKey = 'Organisation.Division';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DivisionForm.init)  {
            DivisionForm.init = true;

            var w0 = IntegerEditor;
            var w1 = DateEditor;
            var w2 = StringEditor;

            initFormType(DivisionForm, [
                'InstituteId', w0,
                'BranchId', w0,
                'DepartmentId', w0,
                'AcademicYearsId', w0,
                'SemesterId', w0,
                'StartDate', w1,
                'EndDate', w1,
                'DivisionName', w2
            ]);
        }
    }
}