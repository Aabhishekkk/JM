import { initFullHeightGridPage } from '@serenity-is/corelib/q';
import { ExamAttemptDetailsGrid } from './ExamAttemptDetailsGrid';

export default function pageInit() {
    initFullHeightGridPage(new ExamAttemptDetailsGrid($('#GridDiv')).element);
}