import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { BatchesGrid } from './BatchesGrid';

export default function pageInit() {
    initFullHeightGridPage(new BatchesGrid($('#GridDiv')).element);
}