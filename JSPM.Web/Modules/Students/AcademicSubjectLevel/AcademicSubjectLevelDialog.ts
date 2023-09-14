import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { AcademicSubjectLevelForm, AcademicSubjectLevelRow, AcademicSubjectLevelService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.AcademicSubjectLevelDialog')
export class AcademicSubjectLevelDialog extends EntityDialog<AcademicSubjectLevelRow, any> {
    protected getFormKey() { return AcademicSubjectLevelForm.formKey; }
    protected getRowDefinition() { return AcademicSubjectLevelRow; }
    protected getService() { return AcademicSubjectLevelService.baseUrl; }

    protected form = new AcademicSubjectLevelForm(this.idPrefix);
}