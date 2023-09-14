import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DepartmentsColumns, DepartmentsRow, DepartmentsService } from '../../ServerTypes/Organisation';
import { DepartmentsDialog } from './DepartmentsDialog';

@Decorators.registerClass('JSPM.Organisation.DepartmentsGrid')
export class DepartmentsGrid extends EntityGrid<DepartmentsRow, any> {
    protected getColumnsKey() { return DepartmentsColumns.columnsKey; }
    protected getDialogType() { return DepartmentsDialog; }
    protected getRowDefinition() { return DepartmentsRow; }
    protected getService() { return DepartmentsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}