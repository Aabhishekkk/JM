import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { JobsOpeningsColumns, JobsOpeningsRow, JobsOpeningsService } from '../../ServerTypes/Jobs';
import { JobsOpeningsDialog } from './JobsOpeningsDialog';

@Decorators.registerClass('JSPM.Jobs.JobsOpeningsGrid')
export class JobsOpeningsGrid extends EntityGrid<JobsOpeningsRow, any> {
    protected getColumnsKey() { return JobsOpeningsColumns.columnsKey; }
    protected getDialogType() { return JobsOpeningsDialog; }
    protected getRowDefinition() { return JobsOpeningsRow; }
    protected getService() { return JobsOpeningsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}