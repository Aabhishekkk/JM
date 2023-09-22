import { fieldsProxy } from "@serenity-is/corelib/q";

export interface JobsOpeningsRow {
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
    SkillsId?: number;
    SkillsSkillCategory?: string;
}

export abstract class JobsOpeningsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'TypeOfEmployement';
    static readonly localTextPrefix = 'Jobs.JobsOpenings';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<JobsOpeningsRow>();
}