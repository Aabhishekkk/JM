import { fieldsProxy } from "@serenity-is/corelib/q";

export interface SubjectsRow {
    Id?: number;
    SubjectName?: string;
    BranchId?: number;
    AcademicYearId?: number;
    SemesterId?: number;
    Priority?: string;
    BranchName?: string;
    SubjectCode?: string;
    Description?: string;
    SubjectType?: string;
}

export abstract class SubjectsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'SubjectName';
    static readonly localTextPrefix = 'Syllabus.Subjects';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<SubjectsRow>();
}