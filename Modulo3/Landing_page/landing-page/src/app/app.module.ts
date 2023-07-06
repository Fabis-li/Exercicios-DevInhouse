import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ExperienciaComponent } from './experiencia/experiencia.component';
import { SobreComponent } from './sobre/sobre.component';
import { HabilidadesComponent } from './habilidades/habilidades.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ExperienciaComponent,
    SobreComponent,
    HabilidadesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
