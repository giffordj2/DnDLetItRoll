using DnDLetItRoll.Domain.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Test
{
    [TestClass]
    public class CharacterTest
    {
        private Character character = new Character()
        {
            Id = 1,
            CharacterName = "Harry",
            RaceId = 1,
            Race = new Race()
            {
                Id = 1,
                Name = "Dwarf",
                Description = "Bold and Hardy, Dwarves are known as skilled warriors, miners, and workers of stone and metal.",
                StatIncreased = "Constitution",
                IncreaseAmount = 2,
                Size = "Medium",
                Speed = 25,
                Languages = { "Common", "Dwarvish" },
                RacialTraits = { "Darkvision",
                    "Dwarven Resilience",
                    "Dwarven Combat Training",
                    "Stonecunning" }
            },
            ClassId = 1,
            Class = new Class()
            {
                Id = 1,
                Name = "Barbarian",
                Description = "A fierce warrior of primitive background who can enter a battle rage.",
                HitDie = "d12"
            },
            Level = 1,
            HitPoints = 30,
            Speed = 25,
            Strength = 15,
            Dexterity = 13,
            Constitution = 14,
            Intelligence = 8,
            Charisma = 12,
            Wisdom = 10
            
        };


        [TestMethod]
        public void TestCharacterGetModifer()
        {
            double modifer = character.GetModifer(character.Strength);
            Assert.AreEqual(2, modifer);
        }
    }
}
