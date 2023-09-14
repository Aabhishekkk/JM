import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { AcademicSubjectLevelGrid } from './AcademicSubjectLevelGrid';

export default function pageInit() {
    initFullHeightGridPage(new AcademicSubjectLevelGrid($('#GridDiv')).element);
}