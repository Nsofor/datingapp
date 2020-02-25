using datingapp2.api.Models;
using Microsoft.EntityFrameworkCore;

namespace datingapp2.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) {}  

        public DbSet<Value> Values { get; set; }
    }
}