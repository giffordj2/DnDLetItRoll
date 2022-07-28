using DnDLetItRoll.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Domain.Services
{
    public interface IBackgroundRepository
    {
        IEnumerable<Background> AllBackgrounds { get; }
        Background GetBackgroundById(int backgroundId);
        void InsertBackground(Background background);
        void Deletebackground(int backgroundID);
        void UpdateBackground(Background background);
        void Save();
    }
}
