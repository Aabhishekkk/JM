import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamAttemptDetailsColumns, ExamAttemptDetailsRow, ExamAttemptDetailsService } from '../../ServerTypes/Examinations';
import { ExamAttemptDetailsDialog } from './ExamAttemptDetailsDialog';

@Decorators.registerClass('JSPM.Examinations.ExamAttemptDetailsGrid')
export class ExamAttemptDetailsGrid extends EntityGrid<ExamAttemptDetailsRow, any> {
    protected getColumnsKey() { return ExamAttemptDetailsColumns.columnsKey; }
    protected getDialogType() { return ExamAttemptDetailsDialog; }
    protected getRowDefinition() { return ExamAttemptDetailsRow; }
    protected getService() { return ExamAttemptDetailsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}