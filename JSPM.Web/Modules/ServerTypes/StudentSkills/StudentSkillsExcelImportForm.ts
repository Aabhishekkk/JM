import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface StudentSkillsExcelImportForm {
    FileName: ImageUploadEditor;
}

export class StudentSkillsExcelImportForm extends PrefixedContext {
    static formKey = 'StudentSkills.StudentSkillsExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!StudentSkillsExcelImportForm.init)  {
            StudentSkillsExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(StudentSkillsExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}