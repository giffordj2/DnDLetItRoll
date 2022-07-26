using System.Collections.Generic;

namespace DnDLetItRoll.Domain.Models
{
    public class Subrace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StatIncreased { get; set; }
        public int IncreaseAmount { get; set; }
        public List<string> RacialTraits { get; set; } = new List<string>();
        public int RaceId { get; set; }
       
    }
}