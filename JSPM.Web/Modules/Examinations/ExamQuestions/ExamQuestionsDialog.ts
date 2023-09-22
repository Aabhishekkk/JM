import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamQuestionsForm, ExamQuestionsRow, ExamQuestionsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('JSPM.Examinations.ExamQuestionsDialog')
export class ExamQuestionsDialog extends EntityDialog<ExamQuestionsRow, any> {
    protected getFormKey() { return ExamQuestionsForm.formKey; }
    protected getRowDefinition() { return ExamQuestionsRow; }
    protected getService() { return ExamQuestionsService.baseUrl; }

    protected form = new ExamQuestionsForm(this.idPrefix);
}