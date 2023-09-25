import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamQuestionsColumns, ExamQuestionsRow, ExamQuestionsService } from '../../ServerTypes/Examination';
import { ExamQuestionsDialog } from './ExamQuestionsDialog';
import { ExamQuestionsExcelImportDialog } from './ExamQuestionsExcelDialog';

@Decorators.registerClass('JSPM.Examination.ExamQuestionsGrid')
export class ExamQuestionsGrid extends EntityGrid<ExamQuestionsRow, any> {
    protected getColumnsKey() { return ExamQuestionsColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionsDialog; }
    protected getRowDefinition() { return ExamQuestionsRow; }
    protected getService() { return ExamQuestionsService.baseUrl; }

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
                var dialog = new ExamQuestionsExcelImportDialog();
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