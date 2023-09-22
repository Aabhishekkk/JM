import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface JobOpeningForm {
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
}

export class JobOpeningForm extends PrefixedContext {
    static formKey = 'Job.JobOpening';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JobOpeningForm.init)  {
            JobOpeningForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(JobOpeningForm, [
                'TypeOfEmployement', w0,
                'Description', w0,
                'Levels', w0,
                'Vacancy', w1,
                'CompanyName', w0,
                'Location', w0,
                'Role', w0,
                'Budget', w0,
                'Shift', w0,
                'Skills', w0
            ]);
        }
    }
}