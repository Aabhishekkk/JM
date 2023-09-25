import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AcademicGrid } from './AcademicGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicGrid($('#GridDiv')).element);
}