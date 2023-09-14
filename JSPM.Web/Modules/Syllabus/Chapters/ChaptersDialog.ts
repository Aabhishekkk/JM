import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ChaptersForm, ChaptersRow, ChaptersService } from '../../ServerTypes/Syllabus';

@Decorators.registerClass('JSPM.Syllabus.ChaptersDialog')
export class ChaptersDialog extends EntityDialog<ChaptersRow, any> {
    protected getFormKey() { return ChaptersForm.formKey; }
    protected getRowDefinition() { return ChaptersRow; }
    protected getService() { return ChaptersService.baseUrl; }

    protected form = new ChaptersForm(this.idPrefix);
}