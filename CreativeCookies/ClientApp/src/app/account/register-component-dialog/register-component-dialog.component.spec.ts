import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterComponentDialogComponent } from './register-component-dialog.component';

describe('RegisterComponentDialogComponent', () => {
  let component: RegisterComponentDialogComponent;
  let fixture: ComponentFixture<RegisterComponentDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegisterComponentDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterComponentDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
