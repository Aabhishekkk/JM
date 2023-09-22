import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ExamSectionsRow {
    Id?: number;
    Name?: string;
    DisplayName?: string;
    ExamId?: string;
    Instructions?: string;
    SectionDurationInSeconds?: number;
    NumberOfQuestions?: number;
    NumberofMandatoryQuestions?: number;
    ExamName?: string;
}

export abstract class ExamSectionsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Examinations.ExamSections';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ExamSectionsRow>();
}