import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { StudentsSkillsForm, StudentsSkillsRow, StudentsSkillsService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.StudentsSkillsDialog')
export class StudentsSkillsDialog extends EntityDialog<StudentsSkillsRow, any> {
    protected getFormKey() { return StudentsSkillsForm.formKey; }
    protected getRowDefinition() { return StudentsSkillsRow; }
    protected getService() { return StudentsSkillsService.baseUrl; }

    protected form = new StudentsSkillsForm(this.idPrefix);
}