import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TeacherEndorsementColumns, TeacherEndorsementRow, TeacherEndorsementService } from '../../ServerTypes/Students';
import { TeacherEndorsementDialog } from './TeacherEndorsementDialog';
import { TeacherEndorsementExcelImportDialog } from './TeacherEndorsementExcelImportDialog';

@Decorators.registerClass('JSPM.Students.TeacherEndorsementGrid')
export class TeacherEndorsementGrid extends EntityGrid<TeacherEndorsementRow, any> {
    protected getColumnsKey() { return TeacherEndorsementColumns.columnsKey; }
    protected getDialogType() { return TeacherEndorsementDialog; }
    protected getRowDefinition() { return TeacherEndorsementRow; }
    protected getService() { return TeacherEndorsementService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
    protected getButtons() {
        var buttons = super.getButtons();
        buttons.push({
            title: 'Import From Excel',
            cssClass: 'export-xlsx-button',
            onClick: () => {
                // open import dialog, let it handle rest
                var dialog = new TeacherEndorsementExcelImportDialog();
                dialog.element.on('dialogclose', () => {
                    this.refresh();
                    dialog = null;
                });
                dialog.dialogOpen();
            },
            separator: true
        });
        return buttons;
    }


}