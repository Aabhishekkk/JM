import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StudentsSkillsColumns, StudentsSkillsRow, StudentsSkillsService } from '../../ServerTypes/Students';
import { StudentsSkillsDialog } from './StudentsSkillsDialog';
import { StudentSkillsExcelImportDialog } from './StudentSkillsExcelImportDialog';

@Decorators.registerClass('JSPM.Students.StudentsSkillsGrid')
export class StudentsSkillsGrid extends EntityGrid<StudentsSkillsRow, any> {
    protected getColumnsKey() { return StudentsSkillsColumns.columnsKey; }
    protected getDialogType() { return StudentsSkillsDialog; }
    protected getRowDefinition() { return StudentsSkillsRow; }
    protected getService() { return StudentsSkillsService.baseUrl; }

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
                var dialog = new StudentSkillsExcelImportDialog();
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