import { Injectable } from '@angular/core';
import { EventosService } from '../swagger/ApiEventos/services/eventos.service';
import { ContratoEventoListRespuestaGeneral } from '../swagger/ApiEventos/models/contrato-evento-list-respuesta-general';
import { HttpContext } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class DatosService {

  Datos: any[] = [
      { "Id": 1, "Nombre": "Evento 01", "Descripcion": "Descripcion evento 01", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/Almuerzo.jpg" }
    , { "Id": 2, "Nombre": "Evento 02", "Descripcion": "Descripcion evento 02", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/concierto.jpeg" }
    , { "Id": 3, "Nombre": "Evento 03", "Descripcion": "Descripcion evento 03", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/Conferencia.jpg" }
    , { "Id": 4, "Nombre": "Evento 04", "Descripcion": "Descripcion evento 04", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/cumpleaños.jpg" }
    , { "Id": 5, "Nombre": "Evento 05", "Descripcion": "Descripcion evento 05", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/curso.jpg" }
    , { "Id": 6, "Nombre": "Evento 06", "Descripcion": "Descripcion evento 06", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/Grado.jpg" }
    , { "Id": 7, "Nombre": "Evento 07", "Descripcion": "Descripcion evento 07", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/Karaoke.jpg" }
    , { "Id": 8, "Nombre": "Evento 08", "Descripcion": "Descripcion evento 08", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/Matrimonio.jpg" }
    , { "Id": 9, "Nombre": "Evento 09", "Descripcion": "Descripcion evento 09", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/show.jpg" }
    , { "Id": 10,"Nombre": "Evento 10", "Descripcion": "Descripcion evento 10", "Fecha": "2024-12-30T12:30:00", "Ubicacion": "Colombia", "Capacidad": 300, Imagen: "./Presentaciones/15.jpg" }
  ];
  constructor(
    private apiEventosService:EventosService
  ) { }

  async obtenerEventos() {
    let datos: any = await new Promise<ContratoEventoListRespuestaGeneral>(
      (resolve, reject) => {
        this.apiEventosService.rootUrl = "https://localhost:7256";
        this.apiEventosService.apiEventosObtenerEventosGet$Json().subscribe({
          next: (success: ContratoEventoListRespuestaGeneral) => {
            resolve(success);
          },
          error: (e) => {
            reject(e.error);
          },
        });
      }
    );
    console.log(datos);
    return datos.resultado;
  }

  MisEventos() {
    return this.Datos;
  }

  CrearEvento(evento: any) {
    evento.Id = this.Datos.length + 1;
    this.Datos.push(evento);
    console.log(this.Datos);
    return this.Datos;
  }

  EditarEvento(id: number, evento: any) {
    let indice = this.Datos.findIndex(x => x.Id == id);
    evento.Id = id;
    this.Datos[indice] = evento;
    return this.Datos;
  }

  EliminarEvento(id: number) {
    let indice = this.Datos.findIndex(x => x.Id == id);
    this.Datos.splice(indice, 1);
    return this.Datos;
  }
}


