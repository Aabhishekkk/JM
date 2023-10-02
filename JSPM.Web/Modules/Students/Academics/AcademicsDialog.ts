import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AcademicsForm, AcademicsRow, AcademicsService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.AcademicsDialog')
export class AcademicsDialog extends EntityDialog<AcademicsRow, any> {
    protected getFormKey() { return AcademicsForm.formKey; }
    protected getRowDefinition() { return AcademicsRow; }
    protected getService() { return AcademicsService.baseUrl; }

    protected form = new AcademicsForm(this.idPrefix);
}