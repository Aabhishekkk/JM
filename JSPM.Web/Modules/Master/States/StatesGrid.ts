import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { StatesColumns, StatesRow, StatesService } from '../../ServerTypes/Master';
import { StatesDialog } from './StatesDialog';

@Decorators.registerClass('JSPM.Master.StatesGrid')
export class StatesGrid extends EntityGrid<StatesRow, any> {
    protected getColumnsKey() { return StatesColumns.columnsKey; }
    protected getDialogType() { return StatesDialog; }
    protected getRowDefinition() { return StatesRow; }
    protected getService() { return StatesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}