import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SemestersForm, SemestersRow, SemestersService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.SemestersDialog')
export class SemestersDialog extends EntityDialog<SemestersRow, any> {
    protected getFormKey() { return SemestersForm.formKey; }
    protected getRowDefinition() { return SemestersRow; }
    protected getService() { return SemestersService.baseUrl; }

    protected form = new SemestersForm(this.idPrefix);
}