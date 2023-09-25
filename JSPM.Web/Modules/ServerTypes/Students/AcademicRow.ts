import { fieldsProxy } from "@serenity-is/corelib/q";

export interface AcademicRow {
    Id?: number;
    CourseLevel?: string;
    CourseName?: string;
    YearOfPassing?: string;
    Percentage?: string;
    Remark?: string;
    PassingType?: string;
    ProjectId?: number;
    StudentId?: number;
    SkillId?: number;
    ProjectType?: string;
    StudentFirstName?: string;
    SkillCategory?: string;
}

export abstract class AcademicRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'CourseLevel';
    static readonly localTextPrefix = 'Students.Academic';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AcademicRow>();
}