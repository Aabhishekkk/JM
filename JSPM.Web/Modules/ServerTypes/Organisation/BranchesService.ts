import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { BranchesRow } from "./BranchesRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace BranchesService {
    export const baseUrl = 'Organisation/Branches';

    export declare function Create(request: SaveRequest<BranchesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<BranchesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BranchesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BranchesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Organisation/Branches/Create",
        Update: "Organisation/Branches/Update",
        Delete: "Organisation/Branches/Delete",
        Retrieve: "Organisation/Branches/Retrieve",
        List: "Organisation/Branches/List",
        ExcelImport: "Organisation/Branches/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>BranchesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}