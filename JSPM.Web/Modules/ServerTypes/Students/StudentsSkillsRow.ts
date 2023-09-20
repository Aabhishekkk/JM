import { fieldsProxy } from "@serenity-is/corelib/q";

export interface StudentsSkillsRow {
    Id?: number;
    ESkillCategory?: string;
    SkillId?: number;
    Rating?: number;
    AknowledgeBy?: string;
    Certification?: string;
    CertificationDetails?: string;
    StudentId?: number;
    SkillCategory?: number;
    SkillName?: string;
    StudentFirstName?: string;
}

export abstract class StudentsSkillsRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'ESkillCategory';
    static readonly localTextPrefix = 'Students.StudentsSkills';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<StudentsSkillsRow>();
}