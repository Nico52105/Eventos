import { Component } from '@angular/core';
import { DatosService } from '../../../../servicios/datos.service';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-listar-eventos',
  templateUrl: './listar-eventos.component.html',
  styleUrl: './listar-eventos.component.css'
})
export class ListarEventosComponent {
  Eventos: any[] = [];
  EventoSeleccionado: any = null;
  AccionActual: "Editar" | "Crear" | "Eliminar" | null = null;
  DatosEvento: any = {
    "Nombre": new FormControl(),
    "Descripcion": new FormControl(),
    "Fecha": new FormControl(),
    "Hora": new FormControl(),
    "Ubicacion": new FormControl(),
    "Capacidad": new FormControl(),
    "Imagen": new FormControl()
  };
  constructor(
    public datosService: DatosService
  ) {
    this.Eventos = this.datosService.MisEventos();
  }

  NuevoEvento(): void {
    this.LimpiarEvento();
    this.AccionActual = "Crear";
  }

  CrearEvento(): void {
    let nuevoEvento = {
      "Nombre": this.DatosEvento.Nombre.value,
      "Descripcion": this.DatosEvento.Descripcion.value,
      "Fecha": this.DatosEvento.Fecha.value,
      "Ubicacion": this.DatosEvento.Ubicacion.value,
      "Capacidad": this.DatosEvento.Capacidad.value,
      "Imagen": this.DatosEvento.Imagen.value
    }
    this.Eventos = this.datosService.CrearEvento(nuevoEvento);
    this.LimpiarEvento();
    this.AccionActual = null;
  }

  EditarEvento(eventoSeleccionado: any): void {
    this.EventoSeleccionado= eventoSeleccionado;
    this.DatosEvento.Nombre.setValue(eventoSeleccionado.Nombre);
    this.DatosEvento.Descripcion.setValue(eventoSeleccionado.Descripcion);
    this.DatosEvento.Fecha.setValue(eventoSeleccionado.Fecha.split("T")[0]);
    this.DatosEvento.Hora.setValue(eventoSeleccionado.Fecha.split("T")[1]);
    this.DatosEvento.Ubicacion.setValue(eventoSeleccionado.Ubicacion);
    this.DatosEvento.Capacidad.setValue(eventoSeleccionado.Capacidad);
    this.DatosEvento.Imagen.setValue(eventoSeleccionado.Imagen);
    this.AccionActual = "Editar";
  }

  GuardarEvento(): void {
    let eventoEditado = {
      "Nombre": this.DatosEvento.Nombre.value,
      "Descripcion": this.DatosEvento.Descripcion.value,
      "Fecha": this.DatosEvento.Fecha.value,
      "Ubicacion": this.DatosEvento.Ubicacion.value,
      "Capacidad": this.DatosEvento.Capacidad.value,
      "Imagen": this.DatosEvento.Imagen.value
    }
    this.Eventos = this.datosService.EditarEvento(this.EventoSeleccionado.Id, eventoEditado);
    this.DatosEvento.Nombre.reset();
    this.DatosEvento.Descripcion.reset();
    this.DatosEvento.Fecha.reset();
    this.DatosEvento.Ubicacion.reset();
    this.DatosEvento.Capacidad.reset();
    this.DatosEvento.Imagen.reset();
    this.AccionActual = null;
  }

  EliminarEvento(eventoSeleccionado: any): void {
    this.EventoSeleccionado = eventoSeleccionado;
    this.AccionActual = "Eliminar";
  }

  ConfirmarEliminarEvento(): void {
    this.Eventos = this.datosService.EliminarEvento(this.EventoSeleccionado.Id);
    this.AccionActual = null;
  }

  LimpiarEvento(): void {
    this.DatosEvento.Nombre.reset();
    this.DatosEvento.Descripcion.reset();
    this.DatosEvento.Fecha.reset();
    this.DatosEvento.Ubicacion.reset();
    this.DatosEvento.Capacidad.reset();
    this.DatosEvento.Imagen.reset();
  }

  
}
