import { Decorators, EditorUtils, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo }
    from '@serenity-is/corelib/q';
import { TeacherEndorsementExcelImportForm } from '../../ServerTypes/TeacherEndorsement';
import { TeacherEndorsementService } from '../../ServerTypes/Students/TeacherEndorsementService';
@Decorators.registerClass('JSPM.TeacherEndorsement.TeacherEndorsementExcelImportDialog')
export class TeacherEndorsementExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return TeacherEndorsementExcelImportForm.formKey; }
    protected form = new TeacherEndorsementExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new TeacherEndorsementExcelImportForm(this.idPrefix);
    }
    protected getDialogTitle(): string {
        return "Excel Import";
    }
    protected getDialogButtons(): DialogButton[] {
        return [
            {
                text: 'Import',
                click: () => {
                    debugger;
                    if (!this.validateBeforeSave())
                        return;
                    if (this.form.FileName.value == null ||
                        isEmptyOrNull(this.form.FileName.value.Filename)) {
                        notifyError("Please select a file!");
                        return;
                    }
                    /*TeacherEndorsementService.ExcelImport({
                        FileName: this.form.FileName.value.Filename,
                    }, response => {
                        notifyInfo(
                            'Inserted: ' + (response.Inserted || 0));
                        if (response.ErrorList != null &&
                            response.ErrorList.length > 0) {
                            notifyError(response.ErrorList.join(',\r\n '));
                        }
                        this.dialogClose();
                    });*/
                },
            },
            {
                text: 'Cancel',
                click: () => this.dialogClose()
            }
        ];
    }
}