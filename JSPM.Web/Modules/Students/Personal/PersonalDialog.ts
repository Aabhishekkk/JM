import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { PersonalForm, PersonalRow, PersonalService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.PersonalDialog')
export class PersonalDialog extends EntityDialog<PersonalRow, any> {
    protected getFormKey() { return PersonalForm.formKey; }
    protected getRowDefinition() { return PersonalRow; }
    protected getService() { return PersonalService.baseUrl; }

    protected form = new PersonalForm(this.idPrefix);
}