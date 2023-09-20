import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface TeacherEndorsementExcelImportForm {
    FileName: ImageUploadEditor;
}

export class TeacherEndorsementExcelImportForm extends PrefixedContext {
    static formKey = 'TeacherEndorsement.TeacherEndorsementExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TeacherEndorsementExcelImportForm.init)  {
            TeacherEndorsementExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(TeacherEndorsementExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}