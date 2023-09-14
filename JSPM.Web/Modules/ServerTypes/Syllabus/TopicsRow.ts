import { fieldsProxy } from "@serenity-is/corelib/q";

export interface TopicsRow {
    Id?: number;
    SubjectId?: number;
    ChapterId?: number;
    TopicName?: string;
    Description?: string;
    Index?: number;
    SubjectName?: string;
    ChapterName?: string;
}

export abstract class TopicsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'TopicName';
    static readonly localTextPrefix = 'Syllabus.Topics';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TopicsRow>();
}