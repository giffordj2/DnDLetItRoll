using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Data
{
    public class RaceRepository : IRaceRepository
    {
        private readonly DnDContext _appDbContext;
        public RaceRepository(DnDContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Race> AllRaces
        {
            get
            {
                return _appDbContext.Races;
            }
        }

        public Race GetRaceById(int raceId)
        {
            return _appDbContext.Races.FirstOrDefault(r => r.Id == raceId);
        }
    }
}
