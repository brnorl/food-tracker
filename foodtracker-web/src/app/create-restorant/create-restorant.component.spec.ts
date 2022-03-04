import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateRestorantComponent } from './create-restorant.component';

describe('CreateRestorantComponent', () => {
  let component: CreateRestorantComponent;
  let fixture: ComponentFixture<CreateRestorantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CreateRestorantComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CreateRestorantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
