import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PersonalColumns, PersonalRow, PersonalService } from '../../ServerTypes/Students';
import { PersonalDialog } from './PersonalDialog';

@Decorators.registerClass('JSPM.Students.PersonalGrid')
export class PersonalGrid extends EntityGrid<PersonalRow, any> {
    protected getColumnsKey() { return PersonalColumns.columnsKey; }
    protected getDialogType() { return PersonalDialog; }
    protected getRowDefinition() { return PersonalRow; }
    protected getService() { return PersonalService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}