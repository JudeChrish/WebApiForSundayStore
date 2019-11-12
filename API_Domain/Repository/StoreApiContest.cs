using API_Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Domain.Repository
{
    public class StoreApiContest : DbContext
    {
        public DbSet<Album>albums { get; set; }
    }
}
