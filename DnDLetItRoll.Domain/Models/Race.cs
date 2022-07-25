using System.Collections.Generic;

namespace DnDLetItRoll.Domain.Models
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public AbilityScoreIncrease ASI { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public List<string> Languages { get; set; } = new List<string>();
        public List<Subrace> Subraces { get; set; } = new List<Subrace>();
        public List<string> RacialTraits { get; set; } = new List<string>();
    }
}