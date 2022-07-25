using DnDLetItRoll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Domain.Services
{
    public interface IClassRepository
    {
        IEnumerable<Class> AllClasses { get; }
        Class GetClassById(int classId);
    }
}
