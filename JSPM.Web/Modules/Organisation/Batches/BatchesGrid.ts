import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BatchesColumns, BatchesRow, BatchesService } from '../../ServerTypes/Organisation';
import { BatchesDialog } from './BatchesDialog';
import { BatchesExcelImportDialog } from './BatchesExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.BatchesGrid')
export class BatchesGrid extends EntityGrid<BatchesRow, any> {
    protected getColumnsKey() { return BatchesColumns.columnsKey; }
    protected getDialogType() { return BatchesDialog; }
    protected getRowDefinition() { return BatchesRow; }
    protected getService() { return BatchesService.baseUrl; }

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
                var dialog = new BatchesExcelImportDialog();
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