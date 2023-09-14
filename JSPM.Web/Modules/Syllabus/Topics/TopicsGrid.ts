import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TopicsColumns, TopicsRow, TopicsService } from '../../ServerTypes/Syllabus';
import { TopicsDialog } from './TopicsDialog';

@Decorators.registerClass('JSPM.Syllabus.TopicsGrid')
export class TopicsGrid extends EntityGrid<TopicsRow, any> {
    protected getColumnsKey() { return TopicsColumns.columnsKey; }
    protected getDialogType() { return TopicsDialog; }
    protected getRowDefinition() { return TopicsRow; }
    protected getService() { return TopicsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}