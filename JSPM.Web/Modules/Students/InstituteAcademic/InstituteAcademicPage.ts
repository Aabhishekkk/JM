import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { InstituteAcademicGrid } from './InstituteAcademicGrid';

export default function pageInit() {
    initFullHeightGridPage(new InstituteAcademicGrid($('#GridDiv')).element);
}