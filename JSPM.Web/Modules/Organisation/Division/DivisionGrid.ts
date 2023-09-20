import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DivisionColumns, DivisionRow, DivisionService } from '../../ServerTypes/Organisation';
import { DivisionDialog } from './DivisionDialog';
import { DivisionExcelImportDialog } from './DivisionExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.DivisionGrid')
export class DivisionGrid extends EntityGrid<DivisionRow, any> {
    protected getColumnsKey() { return DivisionColumns.columnsKey; }
    protected getDialogType() { return DivisionDialog; }
    protected getRowDefinition() { return DivisionRow; }
    protected getService() { return DivisionService.baseUrl; }

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
                var dialog = new DivisionExcelImportDialog();
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
