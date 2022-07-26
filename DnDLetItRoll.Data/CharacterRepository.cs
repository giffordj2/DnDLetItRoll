using DnDLetItRoll.Domain.Models;
using DnDLetItRoll.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDLetItRoll.Data
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DnDContext _appDbContext;
        public CharacterRepository(DnDContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Character> AllCharacters
        {
            get
            {
                return _appDbContext.Characters;
            }
        }

        public Character GetCharacterById(int characterId)
        {
            return _appDbContext.Characters.FirstOrDefault(c => c.Id == characterId);
        }
    }
}
