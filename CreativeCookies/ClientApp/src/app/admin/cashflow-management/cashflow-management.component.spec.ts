import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CashflowManagementComponent } from './cashflow-management.component';

describe('CashflowManagementComponent', () => {
  let component: CashflowManagementComponent;
  let fixture: ComponentFixture<CashflowManagementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CashflowManagementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CashflowManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
