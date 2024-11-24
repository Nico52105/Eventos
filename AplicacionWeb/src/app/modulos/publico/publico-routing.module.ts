import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutPublicoComponent } from './componentes/layout-publico/layout-publico.component';
import { HomeComponent } from './paginas/home/home.component';
import { BuscarComponent } from './paginas/buscar/buscar.component';
import { GestionarComponent } from './paginas/gestionar/gestionar.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutPublicoComponent,
    children: [
      {
        path: '',
        redirectTo: 'bienvenido',
        pathMatch: 'full'
      },
      {
        path: 'bienvenido',
        component: HomeComponent,
      },
      {
        path: 'buscar',
        component: BuscarComponent,
      },
      {
        path: 'gestionar',
        component: GestionarComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PublicoRoutingModule { }
