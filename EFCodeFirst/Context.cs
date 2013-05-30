using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Context : DbContext
    {
        public DbSet<Models.User> Users { get; set; }
    }
}
