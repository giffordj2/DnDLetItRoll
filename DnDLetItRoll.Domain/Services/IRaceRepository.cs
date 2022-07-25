using DnDLetItRoll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Domain.Services
{
    public interface IRaceRepository
    {
        IEnumerable<Race> AllRaces { get; }
        Race GetRaceById(int raceId);
    }
}
