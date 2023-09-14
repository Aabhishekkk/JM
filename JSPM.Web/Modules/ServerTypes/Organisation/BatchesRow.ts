import { fieldsProxy } from "@serenity-is/corelib/q";

export interface BatchesRow {
    Id?: number;
    DivisionId?: number;
    BatchName?: string;
    DivisionName?: string;
}

export abstract class BatchesRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'BatchName';
    static readonly localTextPrefix = 'Organisation.Batches';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<BatchesRow>();
}