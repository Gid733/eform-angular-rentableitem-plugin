import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ContractInspectionCasePageComponent} from './components';

const routes: Routes = [
  {path: ':sdkCaseId/:templateId/:customerId/:rentableItemId', component: ContractInspectionCasePageComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ContractInspectionCaseRoutingModule { }
