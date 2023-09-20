import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SubjectsColumns, SubjectsRow, SubjectsService } from '../../ServerTypes/Syllabus';
import { SubjectExcelImportDialog } from './SubjectExcelImportDialog';
import { SubjectsDialog } from './SubjectsDialog';

@Decorators.registerClass('JSPM.Syllabus.SubjectsGrid')
export class SubjectsGrid extends EntityGrid<SubjectsRow, any> {
    protected getColumnsKey() { return SubjectsColumns.columnsKey; }
    protected getDialogType() { return SubjectsDialog; }
    protected getRowDefinition() { return SubjectsRow; }
    protected getService() { return SubjectsService.baseUrl; }

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
                var dialog = new SubjectExcelImportDialog();
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