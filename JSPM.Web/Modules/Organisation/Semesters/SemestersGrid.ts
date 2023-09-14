import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SemestersColumns, SemestersRow, SemestersService } from '../../ServerTypes/Organisation';
import { SemestersDialog } from './SemestersDialog';

@Decorators.registerClass('JSPM.Organisation.SemestersGrid')
export class SemestersGrid extends EntityGrid<SemestersRow, any> {
    protected getColumnsKey() { return SemestersColumns.columnsKey; }
    protected getDialogType() { return SemestersDialog; }
    protected getRowDefinition() { return SemestersRow; }
    protected getService() { return SemestersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}