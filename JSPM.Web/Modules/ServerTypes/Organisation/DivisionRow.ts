import { fieldsProxy } from "@serenity-is/corelib/q";

export interface DivisionRow {
    Id?: number;
    InstituteId?: number;
    BranchId?: number;
    DepartmentId?: number;
    AcademicYearsId?: number;
    SemesterId?: number;
    StartDate?: string;
    EndDate?: string;
    DivisionName?: string;
    InstituteName?: string;
    BranchName?: string;
    DepartmentName?: string;
}

export abstract class DivisionRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'DivisionName';
    static readonly localTextPrefix = 'Organisation.Division';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<DivisionRow>();
}