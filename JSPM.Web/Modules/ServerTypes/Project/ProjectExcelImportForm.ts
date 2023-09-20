import { ImageUploadEditor, PrefixedContext } from "@serenity-is/corelib";
import { initFormType } from "@serenity-is/corelib/q";

export interface ProjectExcelImportForm {
    FileName: ImageUploadEditor;
}

export class ProjectExcelImportForm extends PrefixedContext {
    static formKey = 'Project.ProjectExcelImport';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProjectExcelImportForm.init)  {
            ProjectExcelImportForm.init = true;

            var w0 = ImageUploadEditor;

            initFormType(ProjectExcelImportForm, [
                'FileName', w0
            ]);
        }
    }
}