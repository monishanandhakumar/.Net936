import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DeptcrudComponent } from './deptcrud.component';

describe('DeptcrudComponent', () => {
  let component: DeptcrudComponent;
  let fixture: ComponentFixture<DeptcrudComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeptcrudComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeptcrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
