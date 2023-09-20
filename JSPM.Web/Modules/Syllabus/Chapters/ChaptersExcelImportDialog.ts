import { Decorators, EntityDialog, PropertyDialog } from '@serenity-is/corelib';
import { DialogButton, isEmptyOrNull, notifyError, notifyInfo } from '@serenity-is/corelib/q';
import { ChaptersExcelImportForm } from '../../ServerTypes/Modules/Syllabus.ChaptersExcelImportForm';
//import { SubjectExcelImportForm } from '../../ServerTypes/Modules';
//import { SubjectExcelImportForm } from '../../ServerTypes/Modules';
import { ChaptersService, SubjectsForm, SubjectsRow, SubjectsService } from '../../ServerTypes/Syllabus';



@Decorators.registerClass('JSPM.Syllabus.ChaptersExcelImportDialog')
export class ChaptersExcelImportDialog extends PropertyDialog<any, any>{
    protected getFormKey() { return ChaptersExcelImportForm.formKey; }
    protected form = new ChaptersExcelImportForm(this.idPrefix);
    constructor() {
        super();
        this.form = new ChaptersExcelImportForm(this.idPrefix);
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
                    ChaptersService.ExcelImport({
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