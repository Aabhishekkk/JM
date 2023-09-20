import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BranchesColumns, BranchesRow, BranchesService } from '../../ServerTypes/Organisation';
import { BranchesDialog } from './BranchesDialog';
import { BranchesExcelImportDialog } from './BranchesExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.BranchesGrid')
export class BranchesGrid extends EntityGrid<BranchesRow, any> {
    protected getColumnsKey() { return BranchesColumns.columnsKey; }
    protected getDialogType() { return BranchesDialog; }
    protected getRowDefinition() { return BranchesRow; }
    protected getService() { return BranchesService.baseUrl; }

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
                var dialog = new BranchesExcelImportDialog();
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