import{u as F,v as E,w as d,x as c}from"../../../_chunks/chunk-2RO2IND5.js";import{a as t,b as i,c as m,e as y,f as u}from"../../../_chunks/chunk-K3EI6ARL.js";var C=i(y(),1);var h=i(u(),1);var f=i(u(),1);var n=class extends f.EntityDialog{constructor(){super(...arguments);this.form=new E(this.idPrefix)}getFormKey(){return E.formKey}getRowDefinition(){return d}getService(){return c.baseUrl}};t(n,"TeacherEndorsementDialog"),n=m([f.Decorators.registerClass("JSPM.Students.TeacherEndorsementDialog")],n);var x=i(u(),1),a=i(y(),1);var g=i(u(),1),w=i(y(),1);var p=class extends g.PrefixedContext{constructor(r){if(super(r),!p.init){p.init=!0;var e=g.ImageUploadEditor;(0,w.initFormType)(p,["FileName",e])}}},o=p;t(o,"TeacherEndorsementExcelImportForm"),o.formKey="TeacherEndorsement.TeacherEndorsementExcelImport";var s=class extends x.PropertyDialog{constructor(){super();this.form=new o(this.idPrefix);this.form=new o(this.idPrefix)}getFormKey(){return o.formKey}getDialogTitle(){return"Excel Import"}getDialogButtons(){return[{text:"Import",click:()=>{debugger;if(this.validateBeforeSave()){if(this.form.FileName.value==null||(0,a.isEmptyOrNull)(this.form.FileName.value.Filename)){(0,a.notifyError)("Please select a file!");return}c.ExcelImport({FileName:this.form.FileName.value.Filename},e=>{(0,a.notifyInfo)("Inserted: "+(e.Inserted||0)),e.ErrorList!=null&&e.ErrorList.length>0&&(0,a.notifyError)(e.ErrorList.join(`,\r
 `)),this.dialogClose()})}}},{text:"Cancel",click:()=>this.dialogClose()}]}};t(s,"TeacherEndorsementExcelImportDialog"),s=m([x.Decorators.registerClass("JSPM.TeacherEndorsement.TeacherEndorsementExcelImportDialog")],s);var l=class extends h.EntityGrid{getColumnsKey(){return F.columnsKey}getDialogType(){return n}getRowDefinition(){return d}getService(){return c.baseUrl}constructor(r){super(r)}getButtons(){var r=super.getButtons();return r.push({title:"Import From Excel",cssClass:"export-xlsx-button",onClick:()=>{var e=new s;e.element.on("dialogclose",()=>{this.refresh(),e=null}),e.dialogOpen()},separator:!0}),r}};t(l,"TeacherEndorsementGrid"),l=m([h.Decorators.registerClass("JSPM.Students.TeacherEndorsementGrid")],l);function S(){(0,C.initFullHeightGridPage)(new l($("#GridDiv")).element)}t(S,"pageInit");export{S as default};
//# sourceMappingURL=TeacherEndorsementPage.js.map
