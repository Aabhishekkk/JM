import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProjectForm, ProjectRow, ProjectService } from '../../ServerTypes/Students';

@Decorators.registerClass('JSPM.Students.ProjectDialog')
export class ProjectDialog extends EntityDialog<ProjectRow, any> {
    protected getFormKey() { return ProjectForm.formKey; }
    protected getRowDefinition() { return ProjectRow; }
    protected getService() { return ProjectService.baseUrl; }

    protected form = new ProjectForm(this.idPrefix);
}