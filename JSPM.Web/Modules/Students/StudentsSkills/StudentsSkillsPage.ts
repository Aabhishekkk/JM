import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { StudentsSkillsGrid } from './StudentsSkillsGrid';

export default function pageInit() {
    initFullHeightGridPage(new StudentsSkillsGrid($('#GridDiv')).element);
}