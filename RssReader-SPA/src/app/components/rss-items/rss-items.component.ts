import { Component, OnInit } from '@angular/core';
import { RssService } from 'src/app/services/rss.service';
import { RssFeed } from 'src/app/models/RssFeed';

@Component({
  selector: 'app-rss-items',
  templateUrl: './rss-items.component.html',
  styleUrls: ['./rss-items.component.css']
})
export class RssItemsComponent implements OnInit {
  feeds: RssFeed[];
  feedItems: any[];

  constructor(private rssService: RssService) { }

  ngOnInit() {
    this.feedItems = [];
    this.getRssFeeds();
  }
  getRssFeeds() {
    this.rssService.getRssFeeds().subscribe(feeds => {
      this.feeds = feeds;
      this.feeds.forEach(feed => {
        feed.items.forEach(item => {
          this.feedItems.push(item);
        });
      });
    });
  }

}
