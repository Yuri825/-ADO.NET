using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTask4CodeFirst
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("DefaultConnection") { }
        public DbSet<Actors> Actor { get; set; }
    }
}
