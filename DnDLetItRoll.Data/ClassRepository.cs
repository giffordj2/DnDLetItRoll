using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Data
{
    public class ClassRepository : IClassRepository
    {
        private readonly DnDContext _appDbContext;
        public ClassRepository(DnDContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Class> AllClasses
        {
            get
            {
                return _appDbContext.Classes;
            }
        }

        public Class GetClassById(int classId)
        {
            return _appDbContext.Classes.FirstOrDefault(c => c.Id == classId);
        }
    }
}
