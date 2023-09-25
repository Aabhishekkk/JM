import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ExamQuestionsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class ExamQuestionsExcelImportForm extends PrefixedContext {
    static formKey = 'Examination.ExamQuestionsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ExamQuestionsExcelImportForm.init)  {
            ExamQuestionsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(ExamQuestionsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}