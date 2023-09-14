import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AcademicSubjectLevelRow {
    Id?: number;
    BranchId?: number;
    AcademicYearId?: number;
    SemesterId?: number;
    DivisionId?: number;
    SubjectId?: number;
    Month?: number;
    Year?: number;
    EStatus?: string;
    Grade?: string;
    Percentage?: number;
    StudentId?: number;
    BranchName?: string;
    DivisionName?: string;
    SubjectName?: string;
    StudentFirstName?: string;
}

export abstract class AcademicSubjectLevelRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'EStatus';
    static readonly localTextPrefix = 'Students.AcademicSubjectLevel';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AcademicSubjectLevelRow>();
}