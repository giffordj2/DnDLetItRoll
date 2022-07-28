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
        public DnDContext()
        {
        }

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
            modelBuilder.Entity<Subrace>().HasData(new Subrace
            {
                Id = 2,
                Name = "Mountain Dwarf",
                Description = "As a mountian dwarf, you're strong and hardy, accustomed to a difficult life in rugged terrain. You're probably on teh tall side (for a dwarf), and tend toward lighter coloration.",
                StatIncreased = "Strength",
                IncreaseAmount = 2,
                RacialTraits =
                {
                    "Dwarven Armor Training"
                },
                RaceId = 1
            });

            //Class seed data
            modelBuilder.Entity<Class>().HasData(new Class
            {
                Id = 1,
                Name = "Barbarian",
                Description = "A fierce warrior of primitive background who can enter a battle rage.",
                HitDie = "d12"
            });

            //Background seed data
            modelBuilder.Entity<Background>().HasData(new Background
            {
                Id = 1,
                Name = "Soldier",
                Description = "War has been your life for as long as you care to remember. You trained as a youth, studied the use of weapons and armor, learned basic survival techniques, including how to stay alive on the battlefield. " +
                 "You might have been part of a standing national army or a mercenary company, or perhaps a member of a local militia who rose to prominence during a recent war."
            });
        }
    }   
}
