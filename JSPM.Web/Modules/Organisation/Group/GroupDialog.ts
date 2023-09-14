import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GroupForm, GroupRow, GroupService } from '../../ServerTypes/Organisation';

@Decorators.registerClass('JSPM.Organisation.GroupDialog')
export class GroupDialog extends EntityDialog<GroupRow, any> {
    protected getFormKey() { return GroupForm.formKey; }
    protected getRowDefinition() { return GroupRow; }
    protected getService() { return GroupService.baseUrl; }

    protected form = new GroupForm(this.idPrefix);
}