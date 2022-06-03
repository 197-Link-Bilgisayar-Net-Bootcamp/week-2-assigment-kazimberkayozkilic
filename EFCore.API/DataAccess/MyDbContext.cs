using EFCore.API.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.API.DataAccess
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
       public DbSet<Gadget> Gadgets { get; set; }
    }
}
