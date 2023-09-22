import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamAttemptDetailsRow {
    Id?: number;
    ExamQuestionId?: number;
    NumberofAttempts?: number;
    BranchId?: number;
    ExamQuestionQuestionNumber?: string;
    BranchName?: string;
}

export abstract class ExamAttemptDetailsRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Examinations.ExamAttemptDetails';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamAttemptDetailsRow>();
}