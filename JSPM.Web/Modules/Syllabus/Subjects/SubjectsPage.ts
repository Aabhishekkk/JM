import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { SubjectsGrid } from './SubjectsGrid';

export default function pageInit() {
    initFullHeightGridPage(new SubjectsGrid($('#GridDiv')).element);
}