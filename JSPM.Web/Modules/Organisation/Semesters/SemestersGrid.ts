import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SemestersColumns, SemestersRow, SemestersService } from '../../ServerTypes/Organisation';
import { SemestersDialog } from './SemestersDialog';
import { SemestersExcelImportDialog } from './SemestersExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.SemestersGrid')
export class SemestersGrid extends EntityGrid<SemestersRow, any> {
    protected getColumnsKey() { return SemestersColumns.columnsKey; }
    protected getDialogType() { return SemestersDialog; }
    protected getRowDefinition() { return SemestersRow; }
    protected getService() { return SemestersService.baseUrl; }

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
                var dialog = new SemestersExcelImportDialog();
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