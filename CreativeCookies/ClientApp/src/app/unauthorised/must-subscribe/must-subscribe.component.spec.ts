import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { MustSubscribeComponent } from './must-subscribe.component';

describe('MustSubscribeComponent', () => {
  let component: MustSubscribeComponent;
  let fixture: ComponentFixture<MustSubscribeComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ MustSubscribeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MustSubscribeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
