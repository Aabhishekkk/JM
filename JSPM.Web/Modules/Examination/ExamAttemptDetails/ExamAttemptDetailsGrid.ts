import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamAttemptDetailsColumns, ExamAttemptDetailsRow, ExamAttemptDetailsService } from '../../ServerTypes/Examination';
import { ExamAttemptDetailsDialog } from './ExamAttemptDetailsDialog';
import { ExamAttemptDetailsExcelImportDialog } from './ExamAttemptDetailsExcelImportDialog';

@Decorators.registerClass('JSPM.Examination.ExamAttemptDetailsGrid')
export class ExamAttemptDetailsGrid extends EntityGrid<ExamAttemptDetailsRow, any> {
    protected getColumnsKey() { return ExamAttemptDetailsColumns.columnsKey; }
    protected getDialogType() { return ExamAttemptDetailsDialog; }
    protected getRowDefinition() { return ExamAttemptDetailsRow; }
    protected getService() { return ExamAttemptDetailsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons() {
        var buttons = super.getButtons();
        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new ExamAttemptDetailsExcelImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            },
            separator: true
        });
        return buttons;
    }
}