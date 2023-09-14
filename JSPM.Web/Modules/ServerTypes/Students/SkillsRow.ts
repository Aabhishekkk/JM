import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SkillsRow {
    Id?: number;
    SkillCategory?: string;
    Rating?: number;
    AknowledgeBy?: string;
    Certification?: string;
    CertificationDetails?: string;
    StudentId?: number;
    StudentFirstName?: string;
}

export abstract class SkillsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SkillCategory';
    static readonly localTextPrefix = 'Students.Skills';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SkillsRow>();
}