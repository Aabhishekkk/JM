import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { AcademicSubjectLevelRow } from "./AcademicSubjectLevelRow";

export namespace AcademicSubjectLevelService {
    export const baseUrl = 'Students/AcademicSubjectLevel';

    export declare function Create(request: SaveRequest<AcademicSubjectLevelRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<AcademicSubjectLevelRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<AcademicSubjectLevelRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<AcademicSubjectLevelRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Students/AcademicSubjectLevel/Create",
        Update: "Students/AcademicSubjectLevel/Update",
        Delete: "Students/AcademicSubjectLevel/Delete",
        Retrieve: "Students/AcademicSubjectLevel/Retrieve",
        List: "Students/AcademicSubjectLevel/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>AcademicSubjectLevelService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}