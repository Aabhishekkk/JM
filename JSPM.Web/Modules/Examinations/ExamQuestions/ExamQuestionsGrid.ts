import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamQuestionsColumns, ExamQuestionsRow, ExamQuestionsService } from '../../ServerTypes/Examinations';
import { ExamQuestionsDialog } from './ExamQuestionsDialog';

@Decorators.registerClass('JSPM.Examinations.ExamQuestionsGrid')
export class ExamQuestionsGrid extends EntityGrid<ExamQuestionsRow, any> {
    protected getColumnsKey() { return ExamQuestionsColumns.columnsKey; }
    protected getDialogType() { return ExamQuestionsDialog; }
    protected getRowDefinition() { return ExamQuestionsRow; }
    protected getService() { return ExamQuestionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}