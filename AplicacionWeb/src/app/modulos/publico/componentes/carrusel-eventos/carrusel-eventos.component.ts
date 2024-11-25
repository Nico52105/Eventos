import { Component } from '@angular/core';
import { DatosService } from '../../../../servicios/datos.service';

@Component({
  selector: 'app-carrusel-eventos',
  templateUrl: './carrusel-eventos.component.html',
  styleUrl: './carrusel-eventos.component.css'
})
export class CarruselEventosComponent {
  PresentacionActual = 0;
  PresentacionesDatos:any[] = [];
  constructor(
    private datosService: DatosService
  ) {}

  async ngOnInit() {
    this.PresentacionesDatos = await this.datosService.obtenerEventos();
  }
  
  scrollToElement(direccion: number): void {  
   let presentaciones = document.querySelectorAll(".presentacion");
    if (this.PresentacionActual + direccion >= presentaciones.length ) {
      this.PresentacionActual = 0;
    }
    else if (this.PresentacionActual + direccion < 0) {
      this.PresentacionActual = presentaciones.length - 1;
    }
    else {
      this.PresentacionActual += direccion;
    }
    console.log(this.PresentacionActual);
   let presentacion:any = presentaciones[this.PresentacionActual];
   if (presentacion) {  
     presentacion.scrollIntoView({ behavior: 'smooth', block: 'start' });  
   }  
 }  
}
