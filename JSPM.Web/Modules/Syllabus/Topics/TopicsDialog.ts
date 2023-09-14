import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { TopicsForm, TopicsRow, TopicsService } from '../../ServerTypes/Syllabus';

@Decorators.registerClass('JSPM.Syllabus.TopicsDialog')
export class TopicsDialog extends EntityDialog<TopicsRow, any> {
    protected getFormKey() { return TopicsForm.formKey; }
    protected getRowDefinition() { return TopicsRow; }
    protected getService() { return TopicsService.baseUrl; }

    protected form = new TopicsForm(this.idPrefix);
}