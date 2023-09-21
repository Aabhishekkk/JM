import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SkillsColumns, SkillsRow, SkillsService } from '../../ServerTypes/Master';
import { SkillsDialog } from './SkillsDialog';
import { SkillsExcelImportDialog } from './SkillsExcelImportDialog';

@Decorators.registerClass('JSPM.Master.SkillsGrid')
export class SkillsGrid extends EntityGrid<SkillsRow, any> {
    protected getColumnsKey() { return SkillsColumns.columnsKey; }
    protected getDialogType() { return SkillsDialog; }
    protected getRowDefinition() { return SkillsRow; }
    protected getService() { return SkillsService.baseUrl; }

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
                var dialog = new SkillsExcelImportDialog();
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