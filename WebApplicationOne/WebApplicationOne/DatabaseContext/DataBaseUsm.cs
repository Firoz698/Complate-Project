using Microsoft.EntityFrameworkCore;
using WebApplicationOne.Models;

namespace WebApplicationOne.DatabaseContext
{
    public class DataBaseUsm : DbContext
    {
        public DataBaseUsm(DbContextOptions<DataBaseUsm> options) : base(options)
        {

        }
        public DbSet<Post> posts { get; set; }



       public DbSet<User> User { get; set; }





    }
}
