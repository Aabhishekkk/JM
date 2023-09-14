import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BatchesColumns, BatchesRow, BatchesService } from '../../ServerTypes/Organisation';
import { BatchesDialog } from './BatchesDialog';

@Decorators.registerClass('JSPM.Organisation.BatchesGrid')
export class BatchesGrid extends EntityGrid<BatchesRow, any> {
    protected getColumnsKey() { return BatchesColumns.columnsKey; }
    protected getDialogType() { return BatchesDialog; }
    protected getRowDefinition() { return BatchesRow; }
    protected getService() { return BatchesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}