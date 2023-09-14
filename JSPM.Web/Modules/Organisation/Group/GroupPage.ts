import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { GroupGrid } from './GroupGrid';

export default function pageInit() {
    initFullHeightGridPage(new GroupGrid($('#GridDiv')).element);
}