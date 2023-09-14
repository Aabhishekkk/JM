import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ProjectRow {
    Id?: number;
    StudentId?: number;
    Type?: string;
    ProjectTitle?: string;
    ProjectDetails?: string;
    ProjectReport?: string;
    StudentFirstName?: string;
}

export abstract class ProjectRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Type';
    static readonly localTextPrefix = 'Students.Project';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ProjectRow>();
}