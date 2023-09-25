import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamsForm, ExamsRow, ExamsService } from '../../ServerTypes/Examination';

@Decorators.registerClass('JSPM.Examination.ExamsDialog')
export class ExamsDialog extends EntityDialog<ExamsRow, any> {
    protected getFormKey() { return ExamsForm.formKey; }
    protected getRowDefinition() { return ExamsRow; }
    protected getService() { return ExamsService.baseUrl; }

    protected form = new ExamsForm(this.idPrefix);
}