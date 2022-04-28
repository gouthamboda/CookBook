import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CookBookListComponent } from './cook-book-list.component';

describe('CookBookListComponent', () => {
  let component: CookBookListComponent;
  let fixture: ComponentFixture<CookBookListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CookBookListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CookBookListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
