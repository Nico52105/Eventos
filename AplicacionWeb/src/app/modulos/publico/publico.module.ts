import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PublicoRoutingModule } from './publico-routing.module';
import { HomeComponent } from './paginas/home/home.component';
import { CarruselEventosComponent } from './componentes/carrusel-eventos/carrusel-eventos.component';
import { LayoutPublicoComponent } from './componentes/layout-publico/layout-publico.component';
import { MenuComponent } from './componentes/menu/menu.component';
import { BuscarComponent } from './paginas/buscar/buscar.component';
import { GestionarComponent } from './paginas/gestionar/gestionar.component';
import { ListarEventosComponent } from './componentes/listar-eventos/listar-eventos.component';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    HomeComponent,
    CarruselEventosComponent,
    LayoutPublicoComponent,
    MenuComponent,
    BuscarComponent,
    GestionarComponent,
    ListarEventosComponent
  ],
  imports: [
    CommonModule,
    PublicoRoutingModule,
    ReactiveFormsModule
  ]
})
export class PublicoModule { }
