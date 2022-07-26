using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Data
{
    public class SubraceRepository : ISubraceRepository
    {
        private readonly DnDContext _appDbContext;
        public SubraceRepository(DnDContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Subrace> SubracesByRaceId(int raceId)
        {
            return _appDbContext.Subraces.Where(r => r.RaceId == raceId);
        }
    }
}
