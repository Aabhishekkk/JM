import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProjectColumns, ProjectRow, ProjectService } from '../../ServerTypes/Students';
import { ProjectDialog } from './ProjectDialog';

@Decorators.registerClass('JSPM.Students.ProjectGrid')
export class ProjectGrid extends EntityGrid<ProjectRow, any> {
    protected getColumnsKey() { return ProjectColumns.columnsKey; }
    protected getDialogType() { return ProjectDialog; }
    protected getRowDefinition() { return ProjectRow; }
    protected getService() { return ProjectService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}