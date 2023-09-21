import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProjectColumns, ProjectRow, ProjectService } from '../../ServerTypes/Students';
import { ProjectDialog } from './ProjectDialog';
import { ProjectExcelImportDialog } from './ProjectExcelImportDialog';
@Decorators.registerClass('JSPM.Students.ProjectGrid')
export class ProjectGrid extends EntityGrid<ProjectRow, any> {
    protected getColumnsKey() { return ProjectColumns.columnsKey; }
    protected getDialogType() { return ProjectDialog; }
    protected getRowDefinition() { return ProjectRow; }
    protected getService() { return ProjectService.baseUrl; }

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
                var dialog = new ProjectExcelImportDialog();
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
