import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterDialogContentComponent } from './register-dialog-content.component';

describe('RegisterDialogContentComponent', () => {
  let component: RegisterDialogContentComponent;
  let fixture: ComponentFixture<RegisterDialogContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RegisterDialogContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RegisterDialogContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
