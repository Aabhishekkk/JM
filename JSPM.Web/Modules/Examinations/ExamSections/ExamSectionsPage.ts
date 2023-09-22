import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamSectionsGrid } from './ExamSectionsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamSectionsGrid($('#GridDiv')).element);
}