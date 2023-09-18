import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { BatchesRow } from "./BatchesRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace BatchesService {
    export const baseUrl = 'Organisation/Batches';

    export declare function Create(request: SaveRequest<BatchesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<BatchesRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<BatchesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<BatchesRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Organisation/Batches/Create",
        Update: "Organisation/Batches/Update",
        Delete: "Organisation/Batches/Delete",
        Retrieve: "Organisation/Batches/Retrieve",
        List: "Organisation/Batches/List",
        ExcelImport: "Organisation/Batches/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>BatchesService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}