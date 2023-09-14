import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { BatchesForm, BatchesRow, BatchesService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.BatchesDialog')
export class BatchesDialog extends EntityDialog<BatchesRow, any> {
    protected getFormKey() { return BatchesForm.formKey; }
    protected getRowDefinition() { return BatchesRow; }
    protected getService() { return BatchesService.baseUrl; }

    protected form = new BatchesForm(this.idPrefix);
}