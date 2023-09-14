import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteAcademicColumns, InstituteAcademicRow, InstituteAcademicService } from '../../ServerTypes/Students';
import { InstituteAcademicDialog } from './InstituteAcademicDialog';

@Decorators.registerClass('JSPM.Students.InstituteAcademicGrid')
export class InstituteAcademicGrid extends EntityGrid<InstituteAcademicRow, any> {
    protected getColumnsKey() { return InstituteAcademicColumns.columnsKey; }
    protected getDialogType() { return InstituteAcademicDialog; }
    protected getRowDefinition() { return InstituteAcademicRow; }
    protected getService() { return InstituteAcademicService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}