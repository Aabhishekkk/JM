import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AcademicsGrid } from './AcademicsGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicsGrid($('#GridDiv')).element);
}