import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface StudentsSkillsForm {
    ESkillCategory: StringEditor;
    SkillId: IntegerEditor;
    Rating: IntegerEditor;
    AknowledgeBy: StringEditor;
    Certification: StringEditor;
    CertificationDetails: StringEditor;
    StudentId: IntegerEditor;
    SkillCategory: IntegerEditor;
}

export class StudentsSkillsForm extends PrefixedContext {
    static formKey = 'Students.StudentsSkills';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentsSkillsForm.init)  {
            StudentsSkillsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(StudentsSkillsForm, [
                'ESkillCategory', w0,
                'SkillId', w1,
                'Rating', w1,
                'AknowledgeBy', w0,
                'Certification', w0,
                'CertificationDetails', w0,
                'StudentId', w1,
                'SkillCategory', w1
            ]);
        }
    }
}