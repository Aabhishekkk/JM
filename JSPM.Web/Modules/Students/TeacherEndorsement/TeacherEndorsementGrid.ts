import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TeacherEndorsementColumns, TeacherEndorsementRow, TeacherEndorsementService } from '../../ServerTypes/Students';
import { TeacherEndorsementDialog } from './TeacherEndorsementDialog';

@Decorators.registerClass('JSPM.Students.TeacherEndorsementGrid')
export class TeacherEndorsementGrid extends EntityGrid<TeacherEndorsementRow, any> {
    protected getColumnsKey() { return TeacherEndorsementColumns.columnsKey; }
    protected getDialogType() { return TeacherEndorsementDialog; }
    protected getRowDefinition() { return TeacherEndorsementRow; }
    protected getService() { return TeacherEndorsementService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}