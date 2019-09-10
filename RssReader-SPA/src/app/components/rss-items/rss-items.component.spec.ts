import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RssItemsComponent } from './rss-items.component';

describe('RssItemsComponent', () => {
  let component: RssItemsComponent;
  let fixture: ComponentFixture<RssItemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RssItemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RssItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
