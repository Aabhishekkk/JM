import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AcademicSubjectLevelColumns, AcademicSubjectLevelRow, AcademicSubjectLevelService } from '../../ServerTypes/Students';
import { AcademicSubjectLevelDialog } from './AcademicSubjectLevelDialog';

@Decorators.registerClass('JSPM.Students.AcademicSubjectLevelGrid')
export class AcademicSubjectLevelGrid extends EntityGrid<AcademicSubjectLevelRow, any> {
    protected getColumnsKey() { return AcademicSubjectLevelColumns.columnsKey; }
    protected getDialogType() { return AcademicSubjectLevelDialog; }
    protected getRowDefinition() { return AcademicSubjectLevelRow; }
    protected getService() { return AcademicSubjectLevelService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}