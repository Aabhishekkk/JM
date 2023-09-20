import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface AcademicYearsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class AcademicYearsExcelImportForm extends PrefixedContext {
    static formKey = 'AcademicYears.AcademicYearsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AcademicYearsExcelImportForm.init)  {
            AcademicYearsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(AcademicYearsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}