import { IntegerEditor, StringEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface InstituteAcademicForm {
    BranchId: IntegerEditor;
    AcademicYearId: IntegerEditor;
    SemesterId: IntegerEditor;
    DivisionId: IntegerEditor;
    Month: IntegerEditor;
    Year: IntegerEditor;
    EStatus: StringEditor;
    Grade: StringEditor;
    Percentage: DecimalEditor;
    StudentId: IntegerEditor;
}

export class InstituteAcademicForm extends PrefixedContext {
    static formKey = 'Students.InstituteAcademic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!InstituteAcademicForm.init)  {
            InstituteAcademicForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(InstituteAcademicForm, [
                'BranchId', w0,
                'AcademicYearId', w0,
                'SemesterId', w0,
                'DivisionId', w0,
                'Month', w0,
                'Year', w0,
                'EStatus', w1,
                'Grade', w1,
                'Percentage', w2,
                'StudentId', w0
            ]);
        }
    }
}