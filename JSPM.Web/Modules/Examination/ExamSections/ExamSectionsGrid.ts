import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ExamSectionsColumns, ExamSectionsRow, ExamSectionsService } from '../../ServerTypes/Examination';
import { ExamSectionsDialog } from './ExamSectionsDialog';

@Decorators.registerClass('JSPM.Examination.ExamSectionsGrid')
export class ExamSectionsGrid extends EntityGrid<ExamSectionsRow, any> {
    protected getColumnsKey() { return ExamSectionsColumns.columnsKey; }
    protected getDialogType() { return ExamSectionsDialog; }
    protected getRowDefinition() { return ExamSectionsRow; }
    protected getService() { return ExamSectionsService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}