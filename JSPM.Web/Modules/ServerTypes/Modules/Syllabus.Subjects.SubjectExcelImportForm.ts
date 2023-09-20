import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SubjectExcelImportForm {
    FileName: ImageUploadEditor;
}

export class SubjectExcelImportForm extends PrefixedContext {
    static formKey = 'Syllabus.SubjectExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SubjectExcelImportForm.init)  {
            SubjectExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(SubjectExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}