import { ComponentFixture, TestBed } from '@angular/core/testing';

import { B3CdbResultComponent } from './investment-result.component';

describe('B3CdbResultComponent', () => {
  let component: B3CdbResultComponent;
  let fixture: ComponentFixture<B3CdbResultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ B3CdbResultComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(B3CdbResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
