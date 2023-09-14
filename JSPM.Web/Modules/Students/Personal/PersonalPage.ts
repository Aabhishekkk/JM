import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { PersonalGrid } from './PersonalGrid';

export default function pageInit() {
    initFullHeightGridPage(new PersonalGrid($('#GridDiv')).element);
}