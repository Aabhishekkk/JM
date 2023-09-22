import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamsColumns, ExamsRow, ExamsService } from '../../ServerTypes/Examinations';
import { ExamsDialog } from './ExamsDialog';

@Decorators.registerClass('JSPM.Examinations.ExamsGrid')
export class ExamsGrid extends EntityGrid<ExamsRow, any> {
    protected getColumnsKey() { return ExamsColumns.columnsKey; }
    protected getDialogType() { return ExamsDialog; }
    protected getRowDefinition() { return ExamsRow; }
    protected getService() { return ExamsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}