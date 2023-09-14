import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SkillsGrid } from './SkillsGrid';

export default function pageInit() {
    initFullHeightGridPage(new SkillsGrid($('#GridDiv')).element);
}