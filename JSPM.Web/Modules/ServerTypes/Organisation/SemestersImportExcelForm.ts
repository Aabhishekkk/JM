import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SemestersImportExcelForm {
    FileName: ImageUploadEditor;
}

export class SemestersImportExcelForm extends PrefixedContext {
    static formKey = 'Syllabus.SubjectExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SemestersImportExcelForm.init)  {
            SemestersImportExcelForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(SemestersImportExcelForm, [
                'FileName', w0
            ]);
        }
    }
}