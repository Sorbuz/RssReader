using Microsoft.EntityFrameworkCore;
using RssReader.API.Models;

namespace RssReader.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<RssFeedUrl> RssFeeds { get; set; }
    }
}