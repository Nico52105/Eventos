import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CarruselEventosComponent } from './carrusel-eventos.component';

describe('CarruselEventosComponent', () => {
  let component: CarruselEventosComponent;
  let fixture: ComponentFixture<CarruselEventosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CarruselEventosComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CarruselEventosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
