import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { SemestersRow } from "./SemestersRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace SemestersService {
    export const baseUrl = 'Organisation/Semesters';

    export declare function Create(request: SaveRequest<SemestersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<SemestersRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<SemestersRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<SemestersRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Organisation/Semesters/Create",
        Update: "Organisation/Semesters/Update",
        Delete: "Organisation/Semesters/Delete",
        Retrieve: "Organisation/Semesters/Retrieve",
        List: "Organisation/Semesters/List",
        ExcelImport: "Organisation/Semesters/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>SemestersService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}