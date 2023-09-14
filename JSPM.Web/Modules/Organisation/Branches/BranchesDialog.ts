import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { BranchesForm, BranchesRow, BranchesService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.BranchesDialog')
export class BranchesDialog extends EntityDialog<BranchesRow, any> {
    protected getFormKey() { return BranchesForm.formKey; }
    protected getRowDefinition() { return BranchesRow; }
    protected getService() { return BranchesService.baseUrl; }

    protected form = new BranchesForm(this.idPrefix);
}