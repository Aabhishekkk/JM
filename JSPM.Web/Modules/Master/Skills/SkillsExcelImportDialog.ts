import { Decorators, EditorUtils, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo }
    from '@serenity-is/corelib/q';
import { SkillsExcelImportForm } from
    '../../ServerTypes/Skills';
import { SkillsService } from
    '../../ServerTypes/Master';

@Decorators.registerClass('JJSPM.Master.SkillsDialog')
export class SkillsExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return SkillsExcelImportForm.formKey; }
    protected form = new SkillsExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new SkillsExcelImportForm(this.idPrefix);
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
                   SkillsService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                    }, response => {
                        notifyInfo(
                            'Inserted: ' + (response.Inserted || 0));
                        if (response.ErrorList != null &&
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