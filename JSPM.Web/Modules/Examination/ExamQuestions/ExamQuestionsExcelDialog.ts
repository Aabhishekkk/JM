import { Decorators, EditorUtils, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo }
    from '@serenity-is/corelib/q';
import { ExamQuestionsExcelImportForm } from
    '../../ServerTypes/Examination';
import {  ExamQuestionsService } from
    '../../ServerTypes/Examination';
@Decorators.registerClass('JSPM.Examination.ExamQuestionsDialog')
export class ExamQuestionsExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return ExamQuestionsExcelImportForm.formKey; }
    protected form = new ExamQuestionsExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new ExamQuestionsExcelImportForm(this.idPrefix);
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
                    ExamQuestionsService.ExcelImport({
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