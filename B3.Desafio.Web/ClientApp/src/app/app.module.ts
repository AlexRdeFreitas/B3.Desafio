import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { B3CdbFormComponent } from './investment-form/investment-form.component';
import { B3CdbResultComponent } from './investment-result/investment-result.component';

@NgModule({
  declarations: [
    AppComponent,
    B3CdbFormComponent,
    B3CdbResultComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
