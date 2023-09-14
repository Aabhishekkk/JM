import { fieldsProxy } from "@serenity-is/corelib/q";

export interface InstituteRow {
    Id?: number;
    InstituteName?: string;
    Description?: string;
}

export abstract class InstituteRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'InstituteName';
    static readonly localTextPrefix = 'Organisation.Institute';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteRow>();
}