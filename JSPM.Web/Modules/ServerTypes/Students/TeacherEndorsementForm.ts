import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TeacherEndorsementForm {
    TeacherId: IntegerEditor;
    StudentId: IntegerEditor;
    Title: StringEditor;
    Details: StringEditor;
}

export class TeacherEndorsementForm extends PrefixedContext {
    static formKey = 'Students.TeacherEndorsement';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TeacherEndorsementForm.init)  {
            TeacherEndorsementForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(TeacherEndorsementForm, [
                'TeacherId', w0,
                'StudentId', w0,
                'Title', w1,
                'Details', w1
            ]);
        }
    }
}