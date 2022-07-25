using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DnDLetItRoll.Domain.Models
{
    public class Character
    {
        //genneral character info
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public int RaceId { get; set; }
        public Race Race { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }


        //Stats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }



        //Method to get the modifer for one of the character's stats
        public static double GetModifer(int stat)
        {
            return Math.Round((double)(stat - 10) / 2, MidpointRounding.AwayFromZero);
        }

        //Method to get the number and type of dice to be rolled by character
        public static List<int> GetDice(string dice)
        {
            List<int> whichDice = new List<int>();
            foreach (Match m in Regex.Matches(dice, @"\d+"))
            {
                whichDice.Add(Convert.ToInt32(m.Value));
            }

            return whichDice;
        }

        //Method for character to roll a specified number of dice with a specified number of sides
        public static int RollDice(int numberOfDice, int numberOfSides)
        {
            int sum = 0;
            Random diceSide = new Random();

            for (int i = 0; i < numberOfDice; i++)
            {
                sum += diceSide.Next(1, numberOfSides + 1);
            }
            return sum;
        }
    }
}
