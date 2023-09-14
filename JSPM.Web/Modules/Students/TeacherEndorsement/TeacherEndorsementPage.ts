import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TeacherEndorsementGrid } from './TeacherEndorsementGrid';

export default function pageInit() {
    initFullHeightGridPage(new TeacherEndorsementGrid($('#GridDiv')).element);
}