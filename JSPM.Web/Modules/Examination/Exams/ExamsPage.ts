import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamsGrid } from './ExamsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamsGrid($('#GridDiv')).element);
}