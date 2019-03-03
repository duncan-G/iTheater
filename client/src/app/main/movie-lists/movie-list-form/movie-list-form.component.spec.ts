import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieListFormComponent } from './movie-list-form.component';

describe('MovieListFormComponent', () => {
  let component: MovieListFormComponent;
  let fixture: ComponentFixture<MovieListFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MovieListFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MovieListFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
