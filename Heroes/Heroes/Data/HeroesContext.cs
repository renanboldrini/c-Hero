using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Heroes.Models;

namespace Heroes.Models
{
    public class HeroesContext : DbContext
    {
        public HeroesContext (DbContextOptions<HeroesContext> options)
            : base(options)
        {
        }

        public DbSet<Heroes.Models.Categoria> Categoria { get; set; }

        public DbSet<Heroes.Models.Planet> Planet { get; set; }

        public DbSet<Heroes.Models.Hero> Hero { get; set; }
    }
}
