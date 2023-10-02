import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicsColumns, AcademicsRow, AcademicsService } from '../../ServerTypes/Students';
import { AcademicsDialog } from './AcademicsDialog';
import { AcademicsExcelImportDialog } from './AcademicsExcelImportDialog';

@Decorators.registerClass('JSPM.Students.AcademicsGrid')
export class AcademicsGrid extends EntityGrid<AcademicsRow, any> {
    protected getColumnsKey() { return AcademicsColumns.columnsKey; }
    protected getDialogType() { return AcademicsDialog; }
    protected getRowDefinition() { return AcademicsRow; }
    protected getService() { return AcademicsService.baseUrl; }

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
                var dialog = new AcademicsExcelImportDialog();
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