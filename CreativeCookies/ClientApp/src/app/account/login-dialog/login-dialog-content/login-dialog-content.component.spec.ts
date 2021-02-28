import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginDialogContentComponent } from './login-dialog-content.component';

describe('LoginDialogContentComponent', () => {
  let component: LoginDialogContentComponent;
  let fixture: ComponentFixture<LoginDialogContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginDialogContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginDialogContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
