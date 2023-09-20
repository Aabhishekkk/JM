import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SubjectsForm {
    SubjectCode: StringEditor;
    SubjectName: StringEditor;
    BranchId: IntegerEditor;
    AcademicYearId: IntegerEditor;
    SemesterId: IntegerEditor;
    Priority: StringEditor;
    Description: StringEditor;
    SubjectType: StringEditor;
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
                'SubjectCode', w0,
                'SubjectName', w0,
                'BranchId', w1,
                'AcademicYearId', w1,
                'SemesterId', w1,
                'Priority', w0,
                'Description', w0,
                'SubjectType', w0
            ]);
        }
    }
}