using DnDLetItRoll.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Race>()
                .Property(e => e.Languages)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<Race>()
                .Property(e => e.RacialTraits)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<string>>(v));

            modelBuilder.Entity<Subrace>()
                .Property(e => e.RacialTraits)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<List<string>>(v));

            //Race seed data
            modelBuilder.Entity<Race>().HasData(new Race
            {
                Id = 1,
                Name = "Dwarf",
                Description = "Bold and Hardy, Dwarves are known as skilled warriors, miners, and workers of stone and metal.",
                StatIncreased = "Constitution",
                IncreaseAmount = 2,
                Size = "Medium",
                Speed = 25,
                Languages = { "Common", "Dwarvish" },
                RacialTraits = {"Darkvision",
                                "Dwarven Resilience",
                                "Dwarven Combat Training",
                                "Stonecunning"}
            });

            //Subrace seed data
            modelBuilder.Entity<Subrace>().HasData(new Subrace
            {
                Id = 1,
                Name = "Hill Dwarf",
                Description = "As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience.",
                StatIncreased = "Wisdom",
                IncreaseAmount = 1,
                RacialTraits =
                {
                    "Dwarven Toughness"
                },
                RaceId = 1
            });
        }
    }   
}
