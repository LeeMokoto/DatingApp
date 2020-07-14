using DatingApp1.API.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}