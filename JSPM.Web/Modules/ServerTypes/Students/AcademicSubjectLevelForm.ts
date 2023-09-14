import { IntegerEditor, StringEditor, DecimalEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicSubjectLevelForm {
    BranchId: IntegerEditor;
    AcademicYearId: IntegerEditor;
    SemesterId: IntegerEditor;
    DivisionId: IntegerEditor;
    SubjectId: IntegerEditor;
    Month: IntegerEditor;
    Year: IntegerEditor;
    EStatus: StringEditor;
    Grade: StringEditor;
    Percentage: DecimalEditor;
    StudentId: IntegerEditor;
}

export class AcademicSubjectLevelForm extends PrefixedContext {
    static formKey = 'Students.AcademicSubjectLevel';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicSubjectLevelForm.init)  {
            AcademicSubjectLevelForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;
            var w2 = DecimalEditor;

            initFormType(AcademicSubjectLevelForm, [
                'BranchId', w0,
                'AcademicYearId', w0,
                'SemesterId', w0,
                'DivisionId', w0,
                'SubjectId', w0,
                'Month', w0,
                'Year', w0,
                'EStatus', w1,
                'Grade', w1,
                'Percentage', w2,
                'StudentId', w0
            ]);
        }
    }
}