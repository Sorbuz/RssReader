using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RssReader.API.Data;
using CodeHollow.FeedReader;
using System.Collections.Generic;
using RssReader.API.Models;

namespace RssReader.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RssFeedsController : ControllerBase
  {
    private readonly DataContext context;
    public RssFeedsController(DataContext context)
    {
      this.context = context;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetRssItems()
    {
      List<RssFeed> feedList = new List<RssFeed>();

      foreach (var feedSource in context.RssFeeds) {
        var feed = await FeedReader.ReadAsync(feedSource.Url);
       
        
        feedList.Add(new RssFeed{
          Title = feed.Title,
          Link = feed.Link,
          Description = feed.Description,
          ImageUrl = feed.ImageUrl,
          Items = feed.Items,
          LastUpdated = feed.LastUpdatedDate
        });
      }

      return Ok(feedList);
    }

    [HttpGet("urls")]
    public async Task<IActionResult> GetRssUrls()
    {
      var rssFeeds = await context.RssFeeds.ToListAsync();

      return Ok(rssFeeds);
    }

    [HttpGet("urls/{id}")]
    public async Task<IActionResult> GetRssUrl(int id)
    {
      var rssFeed = await context.RssFeeds.FirstOrDefaultAsync(x => x.Id == id);

      return Ok(rssFeed);
    }

  }
}