import { proxyTexts } from "@serenity-is/corelib/q";

namespace JSPM.Texts {

    export declare namespace Db {

        namespace Administration {

            namespace Language {
                export const Id: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }

            namespace Role {
                export const RoleId: string;
                export const RoleName: string;
            }

            namespace RolePermission {
                export const PermissionKey: string;
                export const RoleId: string;
                export const RolePermissionId: string;
                export const RoleRoleName: string;
            }

            namespace Translation {
                export const CustomText: string;
                export const EntityPlural: string;
                export const Key: string;
                export const OverrideConfirmation: string;
                export const SaveChangesButton: string;
                export const SourceLanguage: string;
                export const SourceText: string;
                export const TargetLanguage: string;
                export const TargetText: string;
            }

            namespace User {
                export const DisplayName: string;
                export const Email: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }

            namespace UserPermission {
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }

            namespace UserRole {
                export const RoleId: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }

        namespace Master {

            namespace Skills {
                export const Id: string;
                export const Name: string;
            }

            namespace States {
                export const Id: string;
                export const Name: string;
            }
        }

        namespace Organisation {

            namespace AcademicYears {
                export const AcademicYear: string;
                export const Id: string;
                export const Index: string;
            }

            namespace Batches {
                export const BatchName: string;
                export const DivisionId: string;
                export const DivisionName: string;
                export const Id: string;
            }

            namespace Branches {
                export const BranchCode: string;
                export const BranchName: string;
                export const DepartmentId: string;
                export const DepartmentName: string;
                export const Id: string;
                export const InstituteId: string;
                export const InstituteName: string;
            }

            namespace Departments {
                export const DepartmentName: string;
                export const Id: string;
            }

            namespace Division {
                export const AcademicYearsId: string;
                export const BranchId: string;
                export const BranchName: string;
                export const DepartmentId: string;
                export const DepartmentName: string;
                export const DivisionName: string;
                export const EndDate: string;
                export const Id: string;
                export const InstituteId: string;
                export const InstituteName: string;
                export const SemesterId: string;
                export const StartDate: string;
            }

            namespace Group {
                export const BatchId: string;
                export const BatchName: string;
                export const GroupName: string;
                export const Id: string;
            }

            namespace Institute {
                export const Description: string;
                export const Id: string;
                export const InstituteName: string;
            }

            namespace Semesters {
                export const AcademicYearsId: string;
                export const Id: string;
                export const Index: string;
                export const Semester: string;
            }
        }

        namespace Students {

            namespace AcademicSubjectLevel {
                export const AcademicYearId: string;
                export const BranchId: string;
                export const BranchName: string;
                export const DivisionId: string;
                export const DivisionName: string;
                export const EStatus: string;
                export const Grade: string;
                export const Id: string;
                export const Month: string;
                export const Percentage: string;
                export const SemesterId: string;
                export const StudentFirstName: string;
                export const StudentId: string;
                export const SubjectId: string;
                export const SubjectName: string;
                export const Year: string;
            }

            namespace InstituteAcademic {
                export const AcademicYearId: string;
                export const BranchId: string;
                export const BranchName: string;
                export const DivisionId: string;
                export const DivisionName: string;
                export const EStatus: string;
                export const Grade: string;
                export const Id: string;
                export const Month: string;
                export const Percentage: string;
                export const SemesterId: string;
                export const StudentFirstName: string;
                export const StudentId: string;
                export const Year: string;
            }

            namespace Personal {
                export const AdmissionDate: string;
                export const BranchId: string;
                export const BranchName: string;
                export const City: string;
                export const CurrentAddress: string;
                export const CurrentCity: string;
                export const DepartmentId: string;
                export const DepartmentName: string;
                export const Dob: string;
                export const Email: string;
                export const FirstName: string;
                export const Gender: string;
                export const Id: string;
                export const LastName: string;
                export const MiddleName: string;
                export const MobileNumber: string;
                export const PermanentAddress: string;
                export const Pin: string;
                export const Pnr: string;
            }

            namespace Project {
                export const Id: string;
                export const ProjectDetails: string;
                export const ProjectReport: string;
                export const ProjectTitle: string;
                export const StudentFirstName: string;
                export const StudentId: string;
                export const Type: string;
            }

            namespace Skills {
                export const AknowledgeBy: string;
                export const Certification: string;
                export const CertificationDetails: string;
                export const Id: string;
                export const Rating: string;
                export const SkillCategory: string;
                export const StudentFirstName: string;
                export const StudentId: string;
            }

            namespace TeacherEndorsement {
                export const Details: string;
                export const Id: string;
                export const StudentFirstName: string;
                export const StudentId: string;
                export const TeacherId: string;
                export const Title: string;
            }
        }

        namespace Syllabus {

            namespace Chapters {
                export const ChapterName: string;
                export const Description: string;
                export const Id: string;
                export const Index: string;
                export const SubjectId: string;
                export const SubjectName: string;
            }

            namespace Subjects {
                export const AcademicYearId: string;
                export const BranchId: string;
                export const BranchName: string;
                export const Id: string;
                export const Priority: string;
                export const SemesterId: string;
                export const SubjectName: string;
            }

            namespace Topics {
                export const ChapterId: string;
                export const ChapterName: string;
                export const Description: string;
                export const Id: string;
                export const Index: string;
                export const SubjectId: string;
                export const SubjectName: string;
                export const TopicName: string;
            }
        }
    }

    export declare namespace Forms {

        namespace Membership {

            namespace ChangePassword {
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace ForgotPassword {
                export const BackToLogin: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const SuccessMessage: string;
            }

            namespace Login {
                export const FacebookButton: string;
                export const ForgotPassword: string;
                export const GoogleButton: string;
                export const LoginToYourAccount: string;
                export const OR: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }

            namespace ResetPassword {
                export const BackToLogin: string;
                export const EmailSubject: string;
                export const FormTitle: string;
                export const SubmitButton: string;
                export const Success: string;
            }

            namespace SignUp {
                export const AcceptTerms: string;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const BackToLogin: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
    }

    export declare namespace Navigation {
        export const LogoutLink: string;
        export const SiteTitle: string;
    }

    export declare namespace Site {

        namespace AccessDenied {
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }

        namespace BasicProgressDialog {
            export const CancelTitle: string;
            export const PleaseWait: string;
        }

        namespace BulkServiceAction {
            export const AllHadErrorsFormat: string;
            export const AllSuccessFormat: string;
            export const ConfirmationFormat: string;
            export const ErrorCount: string;
            export const NothingToProcess: string;
            export const SomeHadErrorsFormat: string;
            export const SuccessCount: string;
        }

        namespace Dashboard {
            export const ContentDescription: string;
        }

        namespace Layout {
            export const FooterCopyright: string;
            export const FooterInfo: string;
            export const FooterRights: string;
            export const GeneralSettings: string;
            export const Language: string;
            export const Theme: string;
            export const ThemeBlack: string;
            export const ThemeBlackLight: string;
            export const ThemeBlue: string;
            export const ThemeBlueLight: string;
            export const ThemeGreen: string;
            export const ThemeGreenLight: string;
            export const ThemePurple: string;
            export const ThemePurpleLight: string;
            export const ThemeRed: string;
            export const ThemeRedLight: string;
            export const ThemeYellow: string;
            export const ThemeYellowLight: string;
        }

        namespace RolePermissionDialog {
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }

        namespace UserDialog {
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }

        namespace UserPermissionDialog {
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }

        namespace UserRoleDialog {
            export const DialogTitle: string;
            export const SaveSuccess: string;
        }

        namespace ValidationError {
            export const Title: string;
        }
    }

    export declare namespace Validation {
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

    JSPM['Texts'] = proxyTexts(Texts, '', {Db:{Administration:{Language:{Id:1,LanguageId:1,LanguageName:1},Role:{RoleId:1,RoleName:1},RolePermission:{PermissionKey:1,RoleId:1,RolePermissionId:1,RoleRoleName:1},Translation:{CustomText:1,EntityPlural:1,Key:1,OverrideConfirmation:1,SaveChangesButton:1,SourceLanguage:1,SourceText:1,TargetLanguage:1,TargetText:1},User:{DisplayName:1,Email:1,InsertDate:1,InsertUserId:1,IsActive:1,LastDirectoryUpdate:1,Password:1,PasswordConfirm:1,PasswordHash:1,PasswordSalt:1,Roles:1,Source:1,UpdateDate:1,UpdateUserId:1,UserId:1,UserImage:1,Username:1},UserPermission:{Granted:1,PermissionKey:1,User:1,UserId:1,UserPermissionId:1,Username:1},UserRole:{RoleId:1,User:1,UserId:1,UserRoleId:1,Username:1}},Master:{Skills:{Id:1,Name:1},States:{Id:1,Name:1}},Organisation:{AcademicYears:{AcademicYear:1,Id:1,Index:1},Batches:{BatchName:1,DivisionId:1,DivisionName:1,Id:1},Branches:{BranchCode:1,BranchName:1,DepartmentId:1,DepartmentName:1,Id:1,InstituteId:1,InstituteName:1},Departments:{DepartmentName:1,Id:1},Division:{AcademicYearsId:1,BranchId:1,BranchName:1,DepartmentId:1,DepartmentName:1,DivisionName:1,EndDate:1,Id:1,InstituteId:1,InstituteName:1,SemesterId:1,StartDate:1},Group:{BatchId:1,BatchName:1,GroupName:1,Id:1},Institute:{Description:1,Id:1,InstituteName:1},Semesters:{AcademicYearsId:1,Id:1,Index:1,Semester:1}},Students:{AcademicSubjectLevel:{AcademicYearId:1,BranchId:1,BranchName:1,DivisionId:1,DivisionName:1,EStatus:1,Grade:1,Id:1,Month:1,Percentage:1,SemesterId:1,StudentFirstName:1,StudentId:1,SubjectId:1,SubjectName:1,Year:1},InstituteAcademic:{AcademicYearId:1,BranchId:1,BranchName:1,DivisionId:1,DivisionName:1,EStatus:1,Grade:1,Id:1,Month:1,Percentage:1,SemesterId:1,StudentFirstName:1,StudentId:1,Year:1},Personal:{AdmissionDate:1,BranchId:1,BranchName:1,City:1,CurrentAddress:1,CurrentCity:1,DepartmentId:1,DepartmentName:1,Dob:1,Email:1,FirstName:1,Gender:1,Id:1,LastName:1,MiddleName:1,MobileNumber:1,PermanentAddress:1,Pin:1,Pnr:1},Project:{Id:1,ProjectDetails:1,ProjectReport:1,ProjectTitle:1,StudentFirstName:1,StudentId:1,Type:1},Skills:{AknowledgeBy:1,Certification:1,CertificationDetails:1,Id:1,Rating:1,SkillCategory:1,StudentFirstName:1,StudentId:1},TeacherEndorsement:{Details:1,Id:1,StudentFirstName:1,StudentId:1,TeacherId:1,Title:1}},Syllabus:{Chapters:{ChapterName:1,Description:1,Id:1,Index:1,SubjectId:1,SubjectName:1},Subjects:{AcademicYearId:1,BranchId:1,BranchName:1,Id:1,Priority:1,SemesterId:1,SubjectName:1},Topics:{ChapterId:1,ChapterName:1,Description:1,Id:1,Index:1,SubjectId:1,SubjectName:1,TopicName:1}}},Forms:{Membership:{ChangePassword:{FormTitle:1,SubmitButton:1,Success:1},ForgotPassword:{BackToLogin:1,FormInfo:1,FormTitle:1,SubmitButton:1,SuccessMessage:1},Login:{FacebookButton:1,ForgotPassword:1,GoogleButton:1,LoginToYourAccount:1,OR:1,RememberMe:1,SignInButton:1,SignUpButton:1},ResetPassword:{BackToLogin:1,EmailSubject:1,FormTitle:1,SubmitButton:1,Success:1},SignUp:{AcceptTerms:1,ActivateEmailSubject:1,ActivationCompleteMessage:1,BackToLogin:1,ConfirmEmail:1,ConfirmPassword:1,DisplayName:1,Email:1,FormInfo:1,FormTitle:1,Password:1,SubmitButton:1,Success:1}}},Navigation:{LogoutLink:1,SiteTitle:1},Site:{AccessDenied:{ClickToChangeUser:1,ClickToLogin:1,LackPermissions:1,NotLoggedIn:1,PageTitle:1},BasicProgressDialog:{CancelTitle:1,PleaseWait:1},BulkServiceAction:{AllHadErrorsFormat:1,AllSuccessFormat:1,ConfirmationFormat:1,ErrorCount:1,NothingToProcess:1,SomeHadErrorsFormat:1,SuccessCount:1},Dashboard:{ContentDescription:1},Layout:{FooterCopyright:1,FooterInfo:1,FooterRights:1,GeneralSettings:1,Language:1,Theme:1,ThemeBlack:1,ThemeBlackLight:1,ThemeBlue:1,ThemeBlueLight:1,ThemeGreen:1,ThemeGreenLight:1,ThemePurple:1,ThemePurpleLight:1,ThemeRed:1,ThemeRedLight:1,ThemeYellow:1,ThemeYellowLight:1},RolePermissionDialog:{DialogTitle:1,EditButton:1,SaveSuccess:1},UserDialog:{EditPermissionsButton:1,EditRolesButton:1},UserPermissionDialog:{DialogTitle:1,Grant:1,Permission:1,Revoke:1,SaveSuccess:1},UserRoleDialog:{DialogTitle:1,SaveSuccess:1},ValidationError:{Title:1}},Validation:{AuthenticationError:1,CurrentPasswordMismatch:1,DeleteForeignKeyError:1,EmailConfirm:1,EmailInUse:1,InvalidActivateToken:1,InvalidResetToken:1,MinRequiredPasswordLength:1,PasswordConfirmMismatch:1,SavePrimaryKeyError:1}}) as any;
}

export const Texts = JSPM.Texts;