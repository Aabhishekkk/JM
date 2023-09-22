import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface JobsOpeningsForm {
    TypeOfEmployement: StringEditor;
    Description: StringEditor;
    Levels: StringEditor;
    Vacancy: IntegerEditor;
    CompanyName: StringEditor;
    Location: StringEditor;
    Role: StringEditor;
    Budget: StringEditor;
    Shift: StringEditor;
    Skills: StringEditor;
    SkillsId: IntegerEditor;
}

export class JobsOpeningsForm extends PrefixedContext {
    static formKey = 'Jobs.JobsOpenings';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JobsOpeningsForm.init)  {
            JobsOpeningsForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(JobsOpeningsForm, [
                'TypeOfEmployement', w0,
                'Description', w0,
                'Levels', w0,
                'Vacancy', w1,
                'CompanyName', w0,
                'Location', w0,
                'Role', w0,
                'Budget', w0,
                'Shift', w0,
                'Skills', w0,
                'SkillsId', w1
            ]);
        }
    }
}