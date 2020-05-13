import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {TranslateModule} from '@ngx-translate/core';
import {MDBBootstrapModule} from 'angular-bootstrap-md';
import {EformSharedModule} from '../../../../../common/modules/eform-shared/eform-shared.module';
import {NgSelectModule} from '@ng-select/ng-select';
import {EformImportedModule} from '../../../../../common/modules/eform-imported/eform-imported.module';
import {GallerizeModule} from '@ngx-gallery/gallerize';
import {LightboxModule} from '@ngx-gallery/lightbox';
import {GalleryModule} from '@ngx-gallery/core';
import {FormsModule} from '@angular/forms';
import {FontAwesomeModule} from '@fortawesome/angular-fontawesome';
import {
  ElementAudioComponent,
  ElementCheckboxComponent,
  ElementCommentComponent,
  ElementContainerComponent, ElementDateComponent, ElementEntitysearchComponent, ElementEntityselectComponent,
  ElementMultiselectComponent, ElementNumberComponent, ElementNumberStepperComponent, ElementPdfComponent,
  ElementPictureComponent, ElementSignatureComponent, ElementSingleselectComponent,
  ElementTextComponent, ElementTimerComponent,
  ContractInspectionCaseBlockComponent,
  ContractInspectionCaseHeaderComponent,
  ContractInspectionCasePageComponent,
  ContractInspectionCaseSwitchComponent
} from './components';
import {ContractInspectionCaseRoutingModule} from './contract-inspection-case-routing.module';

@NgModule({
  declarations: [
    ElementTextComponent,
    ElementNumberComponent,
    ElementNumberStepperComponent,
    ElementCheckboxComponent,
    ElementSingleselectComponent,
    ElementPdfComponent,
    ElementAudioComponent,
    ElementDateComponent,
    ElementCommentComponent,
    ElementEntityselectComponent,
    ElementEntitysearchComponent,
    ElementMultiselectComponent,
    ElementTimerComponent,
    ElementContainerComponent,
    ElementPictureComponent,
    ElementSignatureComponent,
    ContractInspectionCaseBlockComponent,
    ContractInspectionCaseHeaderComponent,
    ContractInspectionCasePageComponent,
    ContractInspectionCaseSwitchComponent
  ],
  imports: [
    TranslateModule,
    MDBBootstrapModule,
    EformSharedModule,
    ContractInspectionCaseRoutingModule,
    CommonModule,
    NgSelectModule,
    EformImportedModule,
    GallerizeModule,
    LightboxModule,
    GalleryModule,
    FormsModule,
    FontAwesomeModule
  ]
})
export class ContractInspectionCaseModule {
}
