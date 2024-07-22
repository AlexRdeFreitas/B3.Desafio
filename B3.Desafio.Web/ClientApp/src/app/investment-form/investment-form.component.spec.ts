import { ComponentFixture, TestBed } from '@angular/core/testing';

import { B3CdbFormComponent } from './investment-form.component';

describe('B3CdbFormComponent', () => {
  let component: B3CdbFormComponent;
  let fixture: ComponentFixture<B3CdbFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ B3CdbFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(B3CdbFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
