import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AcademicYearsForm, AcademicYearsRow, AcademicYearsService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.AcademicYearsDialog')
export class AcademicYearsDialog extends EntityDialog<AcademicYearsRow, any> {
    protected getFormKey() { return AcademicYearsForm.formKey; }
    protected getRowDefinition() { return AcademicYearsRow; }
    protected getService() { return AcademicYearsService.baseUrl; }

    protected form = new AcademicYearsForm(this.idPrefix);
}