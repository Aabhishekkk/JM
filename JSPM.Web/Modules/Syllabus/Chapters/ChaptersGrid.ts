import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ChaptersColumns, ChaptersRow, ChaptersService } from '../../ServerTypes/Syllabus';
import { ChaptersDialog } from './ChaptersDialog';

@Decorators.registerClass('JSPM.Syllabus.ChaptersGrid')
export class ChaptersGrid extends EntityGrid<ChaptersRow, any> {
    protected getColumnsKey() { return ChaptersColumns.columnsKey; }
    protected getDialogType() { return ChaptersDialog; }
    protected getRowDefinition() { return ChaptersRow; }
    protected getService() { return ChaptersService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}