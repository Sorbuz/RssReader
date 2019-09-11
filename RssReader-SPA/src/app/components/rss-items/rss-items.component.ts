import { Component, OnInit } from '@angular/core';
import { RssService } from 'src/app/services/rss.service';
import { RssFeed } from 'src/app/models/RssFeed';
import { FeedItem } from 'src/app/models/FeedItem';

@Component({
  selector: 'app-rss-items',
  templateUrl: './rss-items.component.html',
  styleUrls: ['./rss-items.component.css']
})
export class RssItemsComponent implements OnInit {
  feedItems: FeedItem[];

  constructor(private rssService: RssService) { }

  ngOnInit() {
    this.feedItems = [];
    this.getRssFeeds();
  }
  getRssFeeds() {
    return this.rssService.getRssFeeds().subscribe(feeds => {
      feeds.forEach(feed => {
        feed.items.forEach(item => {
          const currentItem: FeedItem = {
            title: item.title,
            categories: item.categories,
            description: item.description,
            id: item.id,
            link: item.link,
            publishingDate: item.publishingDate,
            publishingDateString: item.publishingDateString,
            source: feed.title
          };
          this.feedItems.push(currentItem);
        });
      });
      this.feedItems.sort((a, b) => {
        return b.publishingDate.localeCompare(a.publishingDate);
      });
    });
  }
}
