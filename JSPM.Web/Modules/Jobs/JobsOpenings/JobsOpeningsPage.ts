import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { JobsOpeningsGrid } from './JobsOpeningsGrid';

export default function pageInit() {
    initFullHeightGridPage(new JobsOpeningsGrid($('#GridDiv')).element);
}