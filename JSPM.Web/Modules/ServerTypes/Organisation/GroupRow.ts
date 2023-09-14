import { fieldsProxy } from "@serenity-is/corelib/q";

export interface GroupRow {
    Id?: number;
    BatchId?: number;
    GroupName?: string;
    BatchName?: string;
}

export abstract class GroupRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'GroupName';
    static readonly localTextPrefix = 'Organisation.Group';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<GroupRow>();
}