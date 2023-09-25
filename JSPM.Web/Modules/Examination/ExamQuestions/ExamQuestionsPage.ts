import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamQuestionsGrid } from './ExamQuestionsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamQuestionsGrid($('#GridDiv')).element);
}