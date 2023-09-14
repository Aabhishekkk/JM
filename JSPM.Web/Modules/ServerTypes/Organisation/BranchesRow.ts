import { fieldsProxy } from "@serenity-is/corelib/q";

export interface BranchesRow {
    Id?: number;
    BranchName?: string;
    BranchCode?: string;
    InstituteId?: number;
    DepartmentId?: number;
    InstituteName?: string;
    DepartmentName?: string;
}

export abstract class BranchesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'BranchName';
    static readonly localTextPrefix = 'Organisation.Branches';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<BranchesRow>();
}