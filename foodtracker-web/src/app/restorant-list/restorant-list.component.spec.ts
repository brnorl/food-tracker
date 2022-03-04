import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RestorantListComponent } from './restorant-list.component';

describe('RestorantListComponent', () => {
  let component: RestorantListComponent;
  let fixture: ComponentFixture<RestorantListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RestorantListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RestorantListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
