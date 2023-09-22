import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamSectionsColumns, ExamSectionsRow, ExamSectionsService } from '../../ServerTypes/Examinations';
import { ExamSectionsDialog } from './ExamSectionsDialog';

@Decorators.registerClass('JSPM.Examinations.ExamSectionsGrid')
export class ExamSectionsGrid extends EntityGrid<ExamSectionsRow, any> {
    protected getColumnsKey() { return ExamSectionsColumns.columnsKey; }
    protected getDialogType() { return ExamSectionsDialog; }
    protected getRowDefinition() { return ExamSectionsRow; }
    protected getService() { return ExamSectionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}