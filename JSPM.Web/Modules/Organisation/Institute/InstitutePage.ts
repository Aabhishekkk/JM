import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { InstituteGrid } from './InstituteGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteGrid($('#GridDiv')).element);
}