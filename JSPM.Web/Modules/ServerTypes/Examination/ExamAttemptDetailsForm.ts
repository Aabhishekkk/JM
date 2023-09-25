import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamAttemptDetailsForm {
    ExamQuestionId: StringEditor;
    NumberofAttempts: IntegerEditor;
    BranchId: IntegerEditor;
}

export class ExamAttemptDetailsForm extends PrefixedContext {
    static formKey = 'Examination.ExamAttemptDetails';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptDetailsForm.init)  {
            ExamAttemptDetailsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ExamAttemptDetailsForm, [
                'ExamQuestionId', w0,
                'NumberofAttempts', w1,
                'BranchId', w1
            ]);
        }
    }
}