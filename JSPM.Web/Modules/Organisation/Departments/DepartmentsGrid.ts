import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DepartmentsColumns, DepartmentsRow, DepartmentsService } from '../../ServerTypes/Organisation';
import { DepartmentsDialog } from './DepartmentsDialog';
import { DepartmentsExcelImportDialog } from './DepartmentsExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.DepartmentsGrid')
export class DepartmentsGrid extends EntityGrid<DepartmentsRow, any> {
    protected getColumnsKey() { return DepartmentsColumns.columnsKey; }
    protected getDialogType() { return DepartmentsDialog; }
    protected getRowDefinition() { return DepartmentsRow; }
    protected getService() { return DepartmentsService.baseUrl; }

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
                var dialog = new DepartmentsExcelImportDialog();
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