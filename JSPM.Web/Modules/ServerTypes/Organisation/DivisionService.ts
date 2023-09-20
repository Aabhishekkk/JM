import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { DivisionRow } from "./DivisionRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace DivisionService {
    export const baseUrl = 'Organisation/Division';

    export declare function Create(request: SaveRequest<DivisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DivisionRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DivisionRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Organisation/Division/Create",
        Update: "Organisation/Division/Update",
        Delete: "Organisation/Division/Delete",
        List: "Organisation/Division/List",
        ExcelImport: "Organisation/Division/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>DivisionService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}