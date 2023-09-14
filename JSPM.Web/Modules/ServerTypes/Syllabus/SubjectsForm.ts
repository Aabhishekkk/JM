import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SubjectsForm {
    SubjectName: StringEditor;
    BranchId: IntegerEditor;
    AcademicYearId: IntegerEditor;
    SemesterId: IntegerEditor;
    Priority: StringEditor;
}

export class SubjectsForm extends PrefixedContext {
    static formKey = 'Syllabus.Subjects';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectsForm.init)  {
            SubjectsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(SubjectsForm, [
                'SubjectName', w0,
                'BranchId', w1,
                'AcademicYearId', w1,
                'SemesterId', w1,
                'Priority', w0
            ]);
        }
    }
}