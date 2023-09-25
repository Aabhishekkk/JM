import { StringEditor, IntegerEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicForm {
    CourseLevel: StringEditor;
    CourseName: StringEditor;
    YearOfPassing: StringEditor;
    Percentage: StringEditor;
    Remark: StringEditor;
    PassingType: StringEditor;
    ProjectId: IntegerEditor;
    StudentId: IntegerEditor;
    SkillId: IntegerEditor;
}

export class AcademicForm extends PrefixedContext {
    static formKey = 'Students.Academic';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicForm.init)  {
            AcademicForm.init = true;

            var w0 = StringEditor;
            var w1 = IntegerEditor;

            initFormType(AcademicForm, [
                'CourseLevel', w0,
                'CourseName', w0,
                'YearOfPassing', w0,
                'Percentage', w0,
                'Remark', w0,
                'PassingType', w0,
                'ProjectId', w1,
                'StudentId', w1,
                'SkillId', w1
            ]);
        }
    }
}