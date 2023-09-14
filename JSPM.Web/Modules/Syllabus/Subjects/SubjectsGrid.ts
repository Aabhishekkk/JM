import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SubjectsColumns, SubjectsRow, SubjectsService } from '../../ServerTypes/Syllabus';
import { SubjectsDialog } from './SubjectsDialog';

@Decorators.registerClass('JSPM.Syllabus.SubjectsGrid')
export class SubjectsGrid extends EntityGrid<SubjectsRow, any> {
    protected getColumnsKey() { return SubjectsColumns.columnsKey; }
    protected getDialogType() { return SubjectsDialog; }
    protected getRowDefinition() { return SubjectsRow; }
    protected getService() { return SubjectsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}