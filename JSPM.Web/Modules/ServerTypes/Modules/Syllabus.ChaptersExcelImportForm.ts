import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ChaptersExcelImportForm {
    FileName: ImageUploadEditor;
}

export class ChaptersExcelImportForm extends PrefixedContext {
    static formKey = 'Syllabus.ChaptersExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ChaptersExcelImportForm.init)  {
            ChaptersExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(ChaptersExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}