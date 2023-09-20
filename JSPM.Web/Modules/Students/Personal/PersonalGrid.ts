import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PersonalColumns, PersonalRow, PersonalService } from '../../ServerTypes/Students';
import { PersonalDialog } from './PersonalDialog';
import { PersonalExcelImportDialog } from './PersonalExcelImportDialog';

@Decorators.registerClass('JSPM.Students.PersonalGrid')
export class PersonalGrid extends EntityGrid<PersonalRow, any> {
    protected getColumnsKey() { return PersonalColumns.columnsKey; }
    protected getDialogType() { return PersonalDialog; }
    protected getRowDefinition() { return PersonalRow; }
    protected getService() { return PersonalService.baseUrl; }

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
                var dialog = new PersonalExcelImportDialog();
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