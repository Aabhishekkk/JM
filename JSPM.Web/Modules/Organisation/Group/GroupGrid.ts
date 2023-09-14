import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GroupColumns, GroupRow, GroupService } from '../../ServerTypes/Organisation';
import { GroupDialog } from './GroupDialog';

@Decorators.registerClass('JSPM.Organisation.GroupGrid')
export class GroupGrid extends EntityGrid<GroupRow, any> {
    protected getColumnsKey() { return GroupColumns.columnsKey; }
    protected getDialogType() { return GroupDialog; }
    protected getRowDefinition() { return GroupRow; }
    protected getService() { return GroupService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}