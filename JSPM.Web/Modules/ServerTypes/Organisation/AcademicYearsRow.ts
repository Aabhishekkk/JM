import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AcademicYearsRow {
    Id?: number;
    AcademicYear?: string;
    Index?: number;
}

export abstract class AcademicYearsRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Organisation.AcademicYears';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AcademicYearsRow>();
}