import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamsForm {
    ExamName: StringEditor;
    ExamInstructions: StringEditor;
}

export class ExamsForm extends PrefixedContext {
    static formKey = 'Examinations.Exams';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamsForm.init)  {
            ExamsForm.init = true;

            var w0 = StringEditor;

            initFormType(ExamsForm, [
                'ExamName', w0,
                'ExamInstructions', w0
            ]);
        }
    }
}