import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { ExamAttemptDetailsRow } from "./ExamAttemptDetailsRow";

export namespace ExamAttemptDetailsService {
    export const baseUrl = 'Examinations/ExamAttemptDetails';

    export declare function Create(request: SaveRequest<ExamAttemptDetailsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<ExamAttemptDetailsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ExamAttemptDetailsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ExamAttemptDetailsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Examinations/ExamAttemptDetails/Create",
        Update: "Examinations/ExamAttemptDetails/Update",
        Delete: "Examinations/ExamAttemptDetails/Delete",
        Retrieve: "Examinations/ExamAttemptDetails/Retrieve",
        List: "Examinations/ExamAttemptDetails/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ExamAttemptDetailsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}