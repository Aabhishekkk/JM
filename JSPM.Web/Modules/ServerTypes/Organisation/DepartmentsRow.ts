import { fieldsProxy } from "@serenity-is/corelib/q";

export interface DepartmentsRow {
    Id?: number;
    DepartmentName?: string;
}

export abstract class DepartmentsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'DepartmentName';
    static readonly localTextPrefix = 'Organisation.Departments';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DepartmentsRow>();
}