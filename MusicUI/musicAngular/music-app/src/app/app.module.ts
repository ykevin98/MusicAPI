import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { musicAPIService } from './services';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { musicAppComponents } from "./musicAppComponents/musicAppComponents.module";

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    musicAppComponents
  ],

  providers: [musicAPIService],
  bootstrap: [AppComponent, musicAppComponents]
})
export class AppModule { }
