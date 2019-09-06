using Microsoft.EntityFrameworkCore;
using RssReader.API.Models;

namespace RssReader.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<RssFeed> RssFeeds { get; set; }
    }
}