import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { musicAPIService } from './services';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatrixBoardComponent } from './matrix-board/matrix-board.component';

@NgModule({
  declarations: [
    AppComponent,
    MatrixBoardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [musicAPIService],
  bootstrap: [AppComponent]
})
export class AppModule { }
