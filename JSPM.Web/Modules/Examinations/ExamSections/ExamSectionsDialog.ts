import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ExamSectionsForm, ExamSectionsRow, ExamSectionsService } from '../../ServerTypes/Examinations';

@Decorators.registerClass('JSPM.Examinations.ExamSectionsDialog')
export class ExamSectionsDialog extends EntityDialog<ExamSectionsRow, any> {
    protected getFormKey() { return ExamSectionsForm.formKey; }
    protected getRowDefinition() { return ExamSectionsRow; }
    protected getService() { return ExamSectionsService.baseUrl; }

    protected form = new ExamSectionsForm(this.idPrefix);
}