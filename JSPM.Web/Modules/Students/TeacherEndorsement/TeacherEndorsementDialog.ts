import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TeacherEndorsementForm, TeacherEndorsementRow, TeacherEndorsementService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.TeacherEndorsementDialog')
export class TeacherEndorsementDialog extends EntityDialog<TeacherEndorsementRow, any> {
    protected getFormKey() { return TeacherEndorsementForm.formKey; }
    protected getRowDefinition() { return TeacherEndorsementRow; }
    protected getService() { return TeacherEndorsementService.baseUrl; }

    protected form = new TeacherEndorsementForm(this.idPrefix);
}