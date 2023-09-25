import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamSectionsForm {
    Name: StringEditor;
    DisplayName: StringEditor;
    ExamId: StringEditor;
    Instructions: StringEditor;
    SectionDurationInSeconds: IntegerEditor;
    NumberOfQuestions: IntegerEditor;
    NumberofMandatoryQuestions: IntegerEditor;
}

export class ExamSectionsForm extends PrefixedContext {
    static formKey = 'Examination.ExamSections';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamSectionsForm.init)  {
            ExamSectionsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(ExamSectionsForm, [
                'Name', w0,
                'DisplayName', w0,
                'ExamId', w0,
                'Instructions', w0,
                'SectionDurationInSeconds', w1,
                'NumberOfQuestions', w1,
                'NumberofMandatoryQuestions', w1
            ]);
        }
    }
}