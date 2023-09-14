import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ChaptersGrid } from './ChaptersGrid';

export default function pageInit() {
    initFullHeightGridPage(new ChaptersGrid($('#GridDiv')).element);
}