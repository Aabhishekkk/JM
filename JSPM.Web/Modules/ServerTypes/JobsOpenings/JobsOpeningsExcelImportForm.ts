import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface JobsOpeningsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class JobsOpeningsExcelImportForm extends PrefixedContext {
    static formKey = 'JobsOpenings.JobsOpeningsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JobsOpeningsExcelImportForm.init)  {
            JobsOpeningsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(JobsOpeningsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}