import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { JobsOpeningsColumns, JobsOpeningsRow, JobsOpeningsService } from '../../ServerTypes/Jobs';
import { JobsOpeningsDialog } from './JobsOpeningsDialog';
import { JobsOpeningsExcelImportDialog } from './JobsOpeningsExcelImportDialog';

@Decorators.registerClass('JSPM.Jobs.JobsOpeningsGrid')
export class JobsOpeningsGrid extends EntityGrid<JobsOpeningsRow, any> {
    protected getColumnsKey() { return JobsOpeningsColumns.columnsKey; }
    protected getDialogType() { return JobsOpeningsDialog; }
    protected getRowDefinition() { return JobsOpeningsRow; }
    protected getService() { return JobsOpeningsService.baseUrl; }

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
                var dialog = new JobsOpeningsExcelImportDialog();
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