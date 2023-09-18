import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface DepartmentsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class DepartmentsExcelImportForm extends PrefixedContext {
    static formKey = 'Syllabus.SubjectExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!DepartmentsExcelImportForm.init)  {
            DepartmentsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(DepartmentsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}