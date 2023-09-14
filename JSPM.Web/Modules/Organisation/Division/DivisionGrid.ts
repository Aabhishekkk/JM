import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { DivisionColumns, DivisionRow, DivisionService } from '../../ServerTypes/Organisation';
import { DivisionDialog } from './DivisionDialog';

@Decorators.registerClass('JSPM.Organisation.DivisionGrid')
export class DivisionGrid extends EntityGrid<DivisionRow, any> {
    protected getColumnsKey() { return DivisionColumns.columnsKey; }
    protected getDialogType() { return DivisionDialog; }
    protected getRowDefinition() { return DivisionRow; }
    protected getService() { return DivisionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}