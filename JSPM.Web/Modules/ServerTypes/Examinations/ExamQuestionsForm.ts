import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamQuestionsForm {
    SubId: StringEditor;
    QuestionNumber: StringEditor;
    QuestionDescription: StringEditor;
    QuestionType: StringEditor;
    Marks: StringEditor;
    SemId: IntegerEditor;
    BranchId: IntegerEditor;
}

export class ExamQuestionsForm extends PrefixedContext {
    static formKey = 'Examinations.ExamQuestions';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamQuestionsForm.init)  {
            ExamQuestionsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ExamQuestionsForm, [
                'SubId', w0,
                'QuestionNumber', w0,
                'QuestionDescription', w0,
                'QuestionType', w0,
                'Marks', w0,
                'SemId', w1,
                'BranchId', w1
            ]);
        }
    }
}