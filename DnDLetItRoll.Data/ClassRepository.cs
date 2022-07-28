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
                return _appDbContext.Classes.ToList();
            }
        }

        public void DeleteClass(int classID)
        {
            Class className = _appDbContext.Classes.Find(classID);
            _appDbContext.Classes.Remove(className);
        }

        public Class GetClassById(int classId)
        {
            return _appDbContext.Classes.FirstOrDefault(c => c.Id == classId);
        }

        public void InsertClass(Class className)
        {
            _appDbContext.Classes.Add(className);
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateClass(Class className)
        {
            _appDbContext.Entry(className).State = EntityState.Modified;
        }
    }
}
