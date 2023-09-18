import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib/q";
import { DepartmentsRow } from "./DepartmentsRow";
import { ExcelImportRequest } from "../Extensions/ExcelImportRequest";
import { ExcelImportResponse } from "../Extensions/ExcelImportResponse";

export namespace DepartmentsService {
    export const baseUrl = 'Organisation/Departments';

    export declare function Create(request: SaveRequest<DepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Update(request: SaveRequest<DepartmentsRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<DepartmentsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<DepartmentsRow>) => void, opt?: ServiceOptions<any>): JQueryXHR;
    export declare function ExcelImport(request: ExcelImportRequest, onSuccess?: (response: ExcelImportResponse) => void, opt?: ServiceOptions<any>): JQueryXHR;

    export const Methods = {
        Create: "Organisation/Departments/Create",
        Update: "Organisation/Departments/Update",
        Delete: "Organisation/Departments/Delete",
        Retrieve: "Organisation/Departments/Retrieve",
        List: "Organisation/Departments/List",
        ExcelImport: "Organisation/Departments/ExcelImport"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List', 
        'ExcelImport'
    ].forEach(x => {
        (<any>DepartmentsService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}