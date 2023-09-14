import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { DivisionForm, DivisionRow, DivisionService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.DivisionDialog')
export class DivisionDialog extends EntityDialog<DivisionRow, any> {
    protected getFormKey() { return DivisionForm.formKey; }
    protected getRowDefinition() { return DivisionRow; }
    protected getService() { return DivisionService.baseUrl; }

    protected form = new DivisionForm(this.idPrefix);
}