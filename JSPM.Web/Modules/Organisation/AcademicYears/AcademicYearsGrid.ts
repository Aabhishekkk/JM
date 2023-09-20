import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicYearsColumns, AcademicYearsRow, AcademicYearsService } from '../../ServerTypes/Organisation';
import { AcademicYearsDialog } from './AcademicYearsDialog';
import { AcademicYearsExcelImportDialog } from './AcademicYearsExcelImportDialog';

@Decorators.registerClass('JSPM.Organisation.AcademicYearsGrid')
export class AcademicYearsGrid extends EntityGrid<AcademicYearsRow, any> {
    protected getColumnsKey() { return AcademicYearsColumns.columnsKey; }
    protected getDialogType() { return AcademicYearsDialog; }
    protected getRowDefinition() { return AcademicYearsRow; }
    protected getService() { return AcademicYearsService.baseUrl; }

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
                var dialog = new AcademicYearsExcelImportDialog();
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