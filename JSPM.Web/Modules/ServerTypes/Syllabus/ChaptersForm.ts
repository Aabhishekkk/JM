import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ChaptersForm {
    SubjectId: IntegerEditor;
    ChapterName: StringEditor;
    Description: StringEditor;
    Index: IntegerEditor;
}

export class ChaptersForm extends PrefixedContext {
    static formKey = 'Syllabus.Chapters';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ChaptersForm.init)  {
            ChaptersForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(ChaptersForm, [
                'SubjectId', w0,
                'ChapterName', w1,
                'Description', w1,
                'Index', w0
            ]);
        }
    }
}