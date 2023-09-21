import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface SkillsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class SkillsExcelImportForm extends PrefixedContext {
    static formKey = 'Master.SkillsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!SkillsExcelImportForm.init)  {
            SkillsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(SkillsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}