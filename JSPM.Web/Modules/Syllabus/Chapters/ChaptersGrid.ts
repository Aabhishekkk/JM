import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ChaptersColumns, ChaptersRow, ChaptersService } from '../../ServerTypes/Syllabus';
import { ChaptersDialog } from './ChaptersDialog';
import { ChaptersExcelImportDialog } from './ChaptersExcelImportDialog';

@Decorators.registerClass('JSPM.Syllabus.ChaptersGrid')
export class ChaptersGrid extends EntityGrid<ChaptersRow, any> {
    protected getColumnsKey() { return ChaptersColumns.columnsKey; }
    protected getDialogType() { return ChaptersDialog; }
    protected getRowDefinition() { return ChaptersRow; }
    protected getService() { return ChaptersService.baseUrl; }

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
                var dialog = new ChaptersExcelImportDialog();
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