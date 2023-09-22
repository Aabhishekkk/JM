import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { JobsOpeningsForm, JobsOpeningsRow, JobsOpeningsService } from '../../ServerTypes/Jobs';

@Decorators.registerClass('JSPM.Jobs.JobsOpeningsDialog')
export class JobsOpeningsDialog extends EntityDialog<JobsOpeningsRow, any> {
    protected getFormKey() { return JobsOpeningsForm.formKey; }
    protected getRowDefinition() { return JobsOpeningsRow; }
    protected getService() { return JobsOpeningsService.baseUrl; }

    protected form = new JobsOpeningsForm(this.idPrefix);
}