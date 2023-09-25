import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamAttemptDetailsExcelForm {
    FileName: ImageUploadEditor;
}

export class ExamAttemptDetailsExcelForm extends PrefixedContext {
    static formKey = 'JSPM.ExamAttemptDetailsExcel';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamAttemptDetailsExcelForm.init)  {
            ExamAttemptDetailsExcelForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(ExamAttemptDetailsExcelForm, [
                'FileName', w0
            ]);
        }
    }
}