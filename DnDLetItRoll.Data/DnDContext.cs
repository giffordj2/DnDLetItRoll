using DnDLetItRoll.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Data
{
    public class DnDContext : DbContext
    {
        public DnDContext(DbContextOptions<DnDContext> options)
            :base(options)
        {

        }
        public DbSet<Background> Backgrounds { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Subrace> Subraces { get; set; }
    }
}
