import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicColumns, AcademicRow, AcademicService } from '../../ServerTypes/Students';
import { AcademicDialog } from './AcademicDialog';

@Decorators.registerClass('JSPM.Students.AcademicGrid')
export class AcademicGrid extends EntityGrid<AcademicRow, any> {
    protected getColumnsKey() { return AcademicColumns.columnsKey; }
    protected getDialogType() { return AcademicDialog; }
    protected getRowDefinition() { return AcademicRow; }
    protected getService() { return AcademicService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}