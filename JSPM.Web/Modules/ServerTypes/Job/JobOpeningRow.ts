import { fieldsProxy } from "@serenity-is/corelib/q";

export interface JobOpeningRow {
    Id?: number;
    TypeOfEmployement?: string;
    Description?: string;
    Levels?: string;
    Vacancy?: number;
    CompanyName?: string;
    Location?: string;
    Role?: string;
    Budget?: string;
    Shift?: string;
    Skills?: string;
    SkillId?: string;
    SkillName?: string;
}

export abstract class JobOpeningRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'TypeOfEmployement';
    static readonly localTextPrefix = 'Job.JobOpening';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<JobOpeningRow>();
}