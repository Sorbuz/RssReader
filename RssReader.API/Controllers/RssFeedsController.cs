using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RssReader.API.Data;

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
    public async Task<IActionResult> GetRssFeeds()
    {
      var rssFeeds = await context.RssFeeds.ToListAsync();

      return Ok(rssFeeds);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRssFeed(int id)
    {
      var rssFeed = await context.RssFeeds.FirstOrDefaultAsync(x => x.Id == id);

      return Ok(rssFeed);
    }
  }
}