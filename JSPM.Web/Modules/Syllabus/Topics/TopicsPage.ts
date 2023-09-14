import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { TopicsGrid } from './TopicsGrid';

export default function pageInit() {
    initFullHeightGridPage(new TopicsGrid($('#GridDiv')).element);
}