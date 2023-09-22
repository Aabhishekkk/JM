import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamsForm, ExamsRow, ExamsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('JSPM.Examinations.ExamsDialog')
export class ExamsDialog extends EntityDialog<ExamsRow, any> {
    protected getFormKey() { return ExamsForm.formKey; }
    protected getRowDefinition() { return ExamsRow; }
    protected getService() { return ExamsService.baseUrl; }

    protected form = new ExamsForm(this.idPrefix);
}