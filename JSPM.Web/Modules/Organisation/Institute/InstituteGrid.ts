import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { InstituteColumns, InstituteRow, InstituteService } from '../../ServerTypes/Organisation';
import { InstituteDialog } from './InstituteDialog';

@Decorators.registerClass('JSPM.Organisation.InstituteGrid')
export class InstituteGrid extends EntityGrid<InstituteRow, any> {
    protected getColumnsKey() { return InstituteColumns.columnsKey; }
    protected getDialogType() { return InstituteDialog; }
    protected getRowDefinition() { return InstituteRow; }
    protected getService() { return InstituteService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}