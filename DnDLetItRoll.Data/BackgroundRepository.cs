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
    public class BackgroundRepository : IBackgroundRepository
    {
        private readonly DnDContext _appDbContext;
        public BackgroundRepository(DnDContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Background> AllBackgrounds
        {
            get
            {
                return _appDbContext.Backgrounds.ToList();
            }
        }

        public void Deletebackground(int backgroundID)
        {
            Background background = _appDbContext.Backgrounds.Find(backgroundID);
            _appDbContext.Backgrounds.Remove(background);
        }

        public Background GetBackgroundById(int backgroundId)
        {
            return _appDbContext.Backgrounds.FirstOrDefault(b => b.Id == backgroundId);
        }

        public void InsertBackground(Background background)
        {
            _appDbContext.Backgrounds.Add(background);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateBackground(Background background)
        {
            _appDbContext.Entry(background).State = EntityState.Modified;
        }
    }
}
