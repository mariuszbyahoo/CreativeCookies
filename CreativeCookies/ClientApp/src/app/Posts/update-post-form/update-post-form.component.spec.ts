import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { UpdatePostFormComponent } from './update-post-form.component';

describe('UpdatePostFormComponent', () => {
  let component: UpdatePostFormComponent;
  let fixture: ComponentFixture<UpdatePostFormComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ UpdatePostFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdatePostFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
