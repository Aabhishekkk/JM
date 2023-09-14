import { fieldsProxy } from "@serenity-is/corelib/q";

export interface InstituteAcademicRow {
    Id?: number;
    BranchId?: number;
    AcademicYearId?: number;
    SemesterId?: number;
    DivisionId?: number;
    Month?: number;
    Year?: number;
    EStatus?: string;
    Grade?: string;
    Percentage?: number;
    StudentId?: number;
    BranchName?: string;
    DivisionName?: string;
    StudentFirstName?: string;
}

export abstract class InstituteAcademicRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EStatus';
    static readonly localTextPrefix = 'Students.InstituteAcademic';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<InstituteAcademicRow>();
}