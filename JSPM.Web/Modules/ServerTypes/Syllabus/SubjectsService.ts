import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { SubjectsRow } from "./SubjectsRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace SubjectsService {
    export const baseUrl = 'Syllabus/Subjects';

    export declare function Create(request: SaveRequest<SubjectsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<SubjectsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SubjectsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SubjectsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Syllabus/Subjects/Create",
        Update: "Syllabus/Subjects/Update",
        Delete: "Syllabus/Subjects/Delete",
        Retrieve: "Syllabus/Subjects/Retrieve",
        List: "Syllabus/Subjects/List",
        ExcelImport: "Syllabus/Subjects/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>SubjectsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}