import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AcademicForm, AcademicRow, AcademicService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.AcademicDialog')
export class AcademicDialog extends EntityDialog<AcademicRow, any> {
    protected getFormKey() { return AcademicForm.formKey; }
    protected getRowDefinition() { return AcademicRow; }
    protected getService() { return AcademicService.baseUrl; }

    protected form = new AcademicForm(this.idPrefix);
}