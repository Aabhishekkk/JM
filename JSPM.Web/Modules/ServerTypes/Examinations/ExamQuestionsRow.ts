import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamQuestionsRow {
    Id?: number;
    SubId?: number;
    QuestionNumber?: string;
    QuestionDescription?: string;
    QuestionType?: string;
    Marks?: number;
    SemId?: number;
    BranchId?: number;
    Semester?: string;
    BranchName?: string;
}

export abstract class ExamQuestionsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'QuestionNumber';
    static readonly localTextPrefix = 'Examinations.ExamQuestions';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamQuestionsRow>();
}