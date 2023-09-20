import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TeacherEndorsementForm {
    TeacherId: StringEditor;
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

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(TeacherEndorsementForm, [
                'TeacherId', w0,
                'StudentId', w1,
                'Title', w0,
                'Details', w0
            ]);
        }
    }
}