import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TeacherEndorsementRow {
    Id?: number;
    TeacherId?: number;
    StudentId?: number;
    Title?: string;
    Details?: string;
    StudentFirstName?: string;
}

export abstract class TeacherEndorsementRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Students.TeacherEndorsement';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TeacherEndorsementRow>();
}