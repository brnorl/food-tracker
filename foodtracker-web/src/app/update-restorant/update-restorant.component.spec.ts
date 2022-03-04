import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdateRestorantComponent } from './update-restorant.component';

describe('UpdateRestorantComponent', () => {
  let component: UpdateRestorantComponent;
  let fixture: ComponentFixture<UpdateRestorantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdateRestorantComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UpdateRestorantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
