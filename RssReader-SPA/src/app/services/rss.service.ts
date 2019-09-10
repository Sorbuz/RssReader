import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RssUrl } from '../models/RssUrl';
import { HttpClient } from '@angular/common/http';
import { RssFeed } from '../models/RssFeed';

@Injectable({
  providedIn: 'root'
})
export class RssService {
  baseUrl = 'http://localhost:5000/api/rssfeeds/';
  rssFeeds;

  constructor(private http: HttpClient) {
    this.rssFeeds = [];
    this.getRssFeeds().subscribe(x => {
      this.rssFeeds.push(x);
    });
  }

  getRssFeeds() {
    return this.http.get<RssFeed[]>(this.baseUrl);
  }
}
