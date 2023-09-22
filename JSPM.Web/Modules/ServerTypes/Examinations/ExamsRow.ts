import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamsRow {
    Id?: string;
    ExamName?: string;
    ExamInstructions?: string;
}

export abstract class ExamsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ExamName';
    static readonly localTextPrefix = 'Examinations.Exams';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamsRow>();
}