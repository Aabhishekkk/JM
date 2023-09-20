import { StringEditor, IntegerEditor, DateEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface PersonalForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    MiddleName: StringEditor;
    Email: StringEditor;
    MobileNumber: IntegerEditor;
    Pnr: StringEditor;
    PermanentAddress: StringEditor;
    City: StringEditor;
    Pin: IntegerEditor;
    CurrentAddress: StringEditor;
    CurrentCity: StringEditor;
    Gender: StringEditor;
    Dob: DateEditor;
    AdmissionDate: DateEditor;
    DepartmentId: IntegerEditor;
    BranchId: IntegerEditor;
    DivisionId: IntegerEditor;
}

export class PersonalForm extends PrefixedContext {
    static formKey = 'Students.Personal';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonalForm.init)  {
            PersonalForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;
            var w2 = DateEditor;

            initFormType(PersonalForm, [
                'FirstName', w0,
                'LastName', w0,
                'MiddleName', w0,
                'Email', w0,
                'MobileNumber', w1,
                'Pnr', w0,
                'PermanentAddress', w0,
                'City', w0,
                'Pin', w1,
                'CurrentAddress', w0,
                'CurrentCity', w0,
                'Gender', w0,
                'Dob', w2,
                'AdmissionDate', w2,
                'DepartmentId', w1,
                'BranchId', w1,
                'DivisionId', w1
            ]);
        }
    }
}