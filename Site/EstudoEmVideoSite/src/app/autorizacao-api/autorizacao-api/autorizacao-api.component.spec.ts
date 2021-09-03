import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AutorizacaoApiComponent } from './autorizacao-api.component';

describe('AutorizacaoApiComponent', () => {
  let component: AutorizacaoApiComponent;
  let fixture: ComponentFixture<AutorizacaoApiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AutorizacaoApiComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AutorizacaoApiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
