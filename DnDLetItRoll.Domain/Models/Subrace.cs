using System.Collections.Generic;

namespace DnDLetItRoll.Domain.Models
{
    public class Subrace
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string Description { get; set; }
        public AbilityScoreIncrease ASI { get; set; }
        public List<string> RacialTraits { get; set; } = new List<string>();
    }
}