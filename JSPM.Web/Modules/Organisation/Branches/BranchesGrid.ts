import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { BranchesColumns, BranchesRow, BranchesService } from '../../ServerTypes/Organisation';
import { BranchesDialog } from './BranchesDialog';

@Decorators.registerClass('JSPM.Organisation.BranchesGrid')
export class BranchesGrid extends EntityGrid<BranchesRow, any> {
    protected getColumnsKey() { return BranchesColumns.columnsKey; }
    protected getDialogType() { return BranchesDialog; }
    protected getRowDefinition() { return BranchesRow; }
    protected getService() { return BranchesService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}