import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamAttemptDetailsForm, ExamAttemptDetailsRow, ExamAttemptDetailsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('JSPM.Examinations.ExamAttemptDetailsDialog')
export class ExamAttemptDetailsDialog extends EntityDialog<ExamAttemptDetailsRow, any> {
    protected getFormKey() { return ExamAttemptDetailsForm.formKey; }
    protected getRowDefinition() { return ExamAttemptDetailsRow; }
    protected getService() { return ExamAttemptDetailsService.baseUrl; }

    protected form = new ExamAttemptDetailsForm(this.idPrefix);
}