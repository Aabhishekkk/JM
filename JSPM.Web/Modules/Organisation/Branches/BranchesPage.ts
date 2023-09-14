import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { BranchesGrid } from './BranchesGrid';

export default function pageInit() {
    initFullHeightGridPage(new BranchesGrid($('#GridDiv')).element);
}