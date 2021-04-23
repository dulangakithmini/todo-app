using Microsoft.EntityFrameworkCore;

namespace ToDo.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) : base(options)
        {
        }

        public DbSet<Models.Item> Items { get; set; }
    }
}