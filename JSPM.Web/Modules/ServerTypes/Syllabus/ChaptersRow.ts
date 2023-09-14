import { fieldsProxy } from "@serenity-is/corelib/q";

export interface ChaptersRow {
    Id?: number;
    SubjectId?: number;
    ChapterName?: string;
    Description?: string;
    Index?: number;
    SubjectName?: string;
}

export abstract class ChaptersRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ChapterName';
    static readonly localTextPrefix = 'Syllabus.Chapters';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ChaptersRow>();
}