import { Component, OnInit } from '@angular/core';
import { RssService } from 'src/app/services/rss.service';
import { RssFeed } from 'src/app/models/RssFeed';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  feeds: RssFeed[];

  constructor(private rssService: RssService) { }

  ngOnInit() {
    this.getRssFeeds();
  }
  getRssFeeds() {
    this.rssService.getRssFeeds().subscribe(feeds => {
      this.feeds = feeds;
    });


  }

}
