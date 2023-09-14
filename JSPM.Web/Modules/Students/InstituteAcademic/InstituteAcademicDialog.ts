import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { InstituteAcademicForm, InstituteAcademicRow, InstituteAcademicService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.InstituteAcademicDialog')
export class InstituteAcademicDialog extends EntityDialog<InstituteAcademicRow, any> {
    protected getFormKey() { return InstituteAcademicForm.formKey; }
    protected getRowDefinition() { return InstituteAcademicRow; }
    protected getService() { return InstituteAcademicService.baseUrl; }

    protected form = new InstituteAcademicForm(this.idPrefix);
}