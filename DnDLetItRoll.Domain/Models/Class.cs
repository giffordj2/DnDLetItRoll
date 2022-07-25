using System.Collections.Generic;

namespace DnDLetItRoll.Domain.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string HitDie { get; set; }
    }
}