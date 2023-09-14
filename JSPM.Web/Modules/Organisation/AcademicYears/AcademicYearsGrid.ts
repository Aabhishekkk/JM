import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicYearsColumns, AcademicYearsRow, AcademicYearsService } from '../../ServerTypes/Organisation';
import { AcademicYearsDialog } from './AcademicYearsDialog';

@Decorators.registerClass('JSPM.Organisation.AcademicYearsGrid')
export class AcademicYearsGrid extends EntityGrid<AcademicYearsRow, any> {
    protected getColumnsKey() { return AcademicYearsColumns.columnsKey; }
    protected getDialogType() { return AcademicYearsDialog; }
    protected getRowDefinition() { return AcademicYearsRow; }
    protected getService() { return AcademicYearsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}