import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { StatesGrid } from './StatesGrid';

export default function pageInit() {
    initFullHeightGridPage(new StatesGrid($('#GridDiv')).element);
}