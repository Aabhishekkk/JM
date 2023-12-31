﻿import { fieldsProxy } from "@serenity-is/corelib/q";

export interface PersonalRow {
    Id?: number;
    FirstName?: string;
    MiddleName?: string;
    LastName?: string;
    Email?: string;
    MobileNumber?: string;
    Pnr?: string;
    PermanentAddress?: string;
    City?: string;
    Pin?: number;
    CurrentAddress?: string;
    CurrentCity?: string;
    CurrentState?: string;
    Gender?: string;
    Dob?: string;
    AdmissionDate?: string;
    DepartmentId?: number;
    BranchId?: number;
    DivisionId?: number;
    DivisionName?: string;
    DepartmentName?: string;
    BranchName?: string;
}

export abstract class PersonalRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'FirstName';
    static readonly localTextPrefix = 'Students.Personal';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PersonalRow>();
}