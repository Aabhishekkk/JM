import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { SkillsForm, SkillsRow, SkillsService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.SkillsDialog')
export class SkillsDialog extends EntityDialog<SkillsRow, any> {
    protected getFormKey() { return SkillsForm.formKey; }
    protected getRowDefinition() { return SkillsRow; }
    protected getService() { return SkillsService.baseUrl; }

    protected form = new SkillsForm(this.idPrefix);
}