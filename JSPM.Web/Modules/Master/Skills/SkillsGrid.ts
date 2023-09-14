import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { SkillsColumns, SkillsRow, SkillsService } from '../../ServerTypes/Master';
import { SkillsDialog } from './SkillsDialog';

@Decorators.registerClass('JSPM.Master.SkillsGrid')
export class SkillsGrid extends EntityGrid<SkillsRow, any> {
    protected getColumnsKey() { return SkillsColumns.columnsKey; }
    protected getDialogType() { return SkillsDialog; }
    protected getRowDefinition() { return SkillsRow; }
    protected getService() { return SkillsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}