import { StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SkillsForm {
    Name: StringEditor;
    SkillCategory: StringEditor;
}

export class SkillsForm extends PrefixedContext {
    static formKey = 'Master.Skills';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillsForm.init)  {
            SkillsForm.init = true;

            var w0 = StringEditor;

            initFormType(SkillsForm, [
                'Name', w0,
                'SkillCategory', w0
            ]);
        }
    }
}