import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProjectForm {
    StudentId: IntegerEditor;
    Type: StringEditor;
    ProjectTitle: StringEditor;
    ProjectDetails: StringEditor;
    ProjectReport: StringEditor;
    DepartmentId: IntegerEditor;
    SemesterId: IntegerEditor;
}

export class ProjectForm extends PrefixedContext {
    static formKey = 'Students.Project';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProjectForm.init)  {
            ProjectForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(ProjectForm, [
                'StudentId', w0,
                'Type', w1,
                'ProjectTitle', w1,
                'ProjectDetails', w1,
                'ProjectReport', w1,
                'DepartmentId', w0,
                'SemesterId', w0
            ]);
        }
    }
}