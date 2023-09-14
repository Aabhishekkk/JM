import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SkillsRow {
    Id?: number;
    Name?: string;
}

export abstract class SkillsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Master.Skills';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SkillsRow>();
}