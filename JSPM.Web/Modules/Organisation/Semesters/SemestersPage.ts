import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SemestersGrid } from './SemestersGrid';

export default function pageInit() {
    initFullHeightGridPage(new SemestersGrid($('#GridDiv')).element);
}