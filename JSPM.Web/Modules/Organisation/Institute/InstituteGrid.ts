import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteColumns, InstituteRow, InstituteService } from '../../ServerTypes/Organisation';
import { InstituteDialog } from './InstituteDialog';
import { InstituteExcelImportDialog } from './InstituteExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.InstituteGrid')
export class InstituteGrid extends EntityGrid<InstituteRow, any> {
    protected getColumnsKey() { return InstituteColumns.columnsKey; }
    protected getDialogType() { return InstituteDialog; }
    protected getRowDefinition() { return InstituteRow; }
    protected getService() { return InstituteService.baseUrl; }

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
                var dialog = new InstituteExcelImportDialog();
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