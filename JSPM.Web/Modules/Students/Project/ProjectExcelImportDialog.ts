import { Decorators, EditorUtils, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo }
    from '@serenity-is/corelib/q';
import { ProjectExcelImportForm } from
    '../../ServerTypes/Project';
import { ProjectService } from '../../ServerTypes/Students/ProjectService';
@Decorators.registerClass('JSPM.Project.ProjectExcelImportDialog')
export class ProjectExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return ProjectExcelImportForm.formKey; }
    protected form = new ProjectExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new ProjectExcelImportForm(this.idPrefix);
    }
    protected getDialogTitle(): string {
        return "Excel Import";
    }
    protected getDialogButtons(): DialogButton[] {
        return [
            {
                text: 'Import',
                click: () => {
                    /*debugger;*/
                    if (!this.validateBeforeSave())
                        return;
                    if (this.form.FileName.value == null ||
                        isEmptyOrNull(this.form.FileName.value.Filename)) {
                        notifyError("Please select a file!");
                        return;
                    }
                    ProjectService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                    }, response => {
                        notifyInfo(
                            'Inserted: ' + (response.Inserted || 0));
                        if   (response.ErrorList != null &&
                            response.ErrorList.length > 0) {
                            notifyError(response.ErrorList.join(',\r\n '));
                        }
                        this.dialogClose();
                    });
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }
}