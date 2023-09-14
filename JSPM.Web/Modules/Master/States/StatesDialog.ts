import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { StatesForm, StatesRow, StatesService } from '../../ServerTypes/Master';

@Decorators.registerClass('JSPM.Master.StatesDialog')
export class StatesDialog extends EntityDialog<StatesRow, any> {
    protected getFormKey() { return StatesForm.formKey; }
    protected getRowDefinition() { return StatesRow; }
    protected getService() { return StatesService.baseUrl; }

    protected form = new StatesForm(this.idPrefix);
}