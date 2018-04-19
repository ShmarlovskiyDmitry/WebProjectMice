using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MICE.Domain.Entities;

namespace MICE.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        public EFDbContext() : 
            base("EFDbContext")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<News> NewsContent { get; set; }
    }
}
