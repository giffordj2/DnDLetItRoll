using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using Microsoft.EntityFrameworkCore;
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
                return _appDbContext.Races.ToList();
            }
        }

        public void DeleteRace(int raceID)
        {
            Race race = _appDbContext.Races.Find(raceID);
            _appDbContext.Races.Remove(race);
        }

        public Race GetRaceById(int raceId)
        {
            return _appDbContext.Races.FirstOrDefault(r => r.Id == raceId);
        }

        public void InsertRace(Race race)
        {
            _appDbContext.Races.Add(race);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateRace(Race race)
        {
            _appDbContext.Entry(race).State = EntityState.Modified;

        }
    }
}
