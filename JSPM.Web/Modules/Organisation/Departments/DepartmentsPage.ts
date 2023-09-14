import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { DepartmentsGrid } from './DepartmentsGrid';

export default function pageInit() {
    initFullHeightGridPage(new DepartmentsGrid($('#GridDiv')).element);
}