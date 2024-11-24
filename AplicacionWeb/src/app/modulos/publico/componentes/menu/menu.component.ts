import { AfterViewInit, Component } from '@angular/core';
import { Router } from '@angular/router';
declare var bootstrap: any;
@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  constructor(private router: Router) { }

  ngafterViewInit(): void {
    const menuMovil = document.getElementById('menuMovil')
  }

  redireccionar(pagina: string): void {
    this.router.navigate([pagina]);
  }
}
