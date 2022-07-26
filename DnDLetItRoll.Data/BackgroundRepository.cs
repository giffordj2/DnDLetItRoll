using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
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
                return _appDbContext.Backgrounds;
            }
        }

        public Background GetBackgroundById(int backgroundId)
        {
            return _appDbContext.Backgrounds.FirstOrDefault(b => b.Id == backgroundId);
        }
    }
}
