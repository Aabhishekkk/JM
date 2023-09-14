import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AcademicYearsGrid } from './AcademicYearsGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicYearsGrid($('#GridDiv')).element);
}