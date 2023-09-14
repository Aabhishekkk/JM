import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SkillsForm {
    SkillCategory: StringEditor;
    Rating: IntegerEditor;
    AknowledgeBy: StringEditor;
    Certification: StringEditor;
    CertificationDetails: StringEditor;
    StudentId: IntegerEditor;
}

export class SkillsForm extends PrefixedContext {
    static formKey = 'Students.Skills';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillsForm.init)  {
            SkillsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(SkillsForm, [
                'SkillCategory', w0,
                'Rating', w1,
                'AknowledgeBy', w0,
                'Certification', w0,
                'CertificationDetails', w0,
                'StudentId', w1
            ]);
        }
    }
}