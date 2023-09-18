import { Decorators, EditorUtils, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, Authorization, isEmptyOrNull, notifyError, notifyInfo }
    from '@serenity-is/corelib/q';
import { AcademicYearsExcelImportForm } from
    '../../ServerTypes/Organisation';
import { AcademicYearsService } from '../../ServerTypes/Organisation/AcademicYearsService';
@Decorators.registerClass('JSPM.Institute.InstituteExcelImportDialog')
export class AcademicYearsExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return AcademicYearsExcelImportForm.formKey; }
    protected form = new AcademicYearsExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new AcademicYearsExcelImportForm(this.idPrefix);
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
                    AcademicYearsService.ExcelImport({
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