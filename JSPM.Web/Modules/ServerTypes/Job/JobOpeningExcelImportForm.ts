import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface JobOpeningExcelImportForm {
    FileName: ImageUploadEditor;
}

export class JobOpeningExcelImportForm extends PrefixedContext {
    static formKey = 'Job.JobOpeningExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JobOpeningExcelImportForm.init)  {
            JobOpeningExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(JobOpeningExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}