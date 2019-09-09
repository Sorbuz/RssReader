using System;
using System.Collections.Generic;
using CodeHollow.FeedReader;

namespace RssReader.API.Models
{
    public class RssFeed
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<FeedItem> Items { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}