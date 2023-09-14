import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SubjectsForm, SubjectsRow, SubjectsService } from '../../ServerTypes/Syllabus';

@Decorators.registerClass('JSPM.Syllabus.SubjectsDialog')
export class SubjectsDialog extends EntityDialog<SubjectsRow, any> {
    protected getFormKey() { return SubjectsForm.formKey; }
    protected getRowDefinition() { return SubjectsRow; }
    protected getService() { return SubjectsService.baseUrl; }

    protected form = new SubjectsForm(this.idPrefix);
}