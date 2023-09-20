import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SemestersRow {
    Id?: number;
    Semester?: string;
    AcademicYearsId?: number;
    Index?: number;
}

export abstract class SemestersRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'Organisation.Semesters';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SemestersRow>();
}