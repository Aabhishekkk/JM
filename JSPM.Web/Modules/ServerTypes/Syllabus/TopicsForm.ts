import { IntegerEditor, StringEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TopicsForm {
    SubjectId: IntegerEditor;
    ChapterId: IntegerEditor;
    TopicName: StringEditor;
    Description: StringEditor;
    Index: IntegerEditor;
}

export class TopicsForm extends PrefixedContext {
    static formKey = 'Syllabus.Topics';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TopicsForm.init)  {
            TopicsForm.init = true;

            var w0 = IntegerEditor;
            var w1 = StringEditor;

            initFormType(TopicsForm, [
                'SubjectId', w0,
                'ChapterId', w0,
                'TopicName', w1,
                'Description', w1,
                'Index', w0
            ]);
        }
    }
}