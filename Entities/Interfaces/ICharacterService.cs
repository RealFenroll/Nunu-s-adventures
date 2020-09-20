using Nunu_s_Adventures.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunu_s_Adventures.Entities.Interfaces
{
    public interface ICharacterService
    {
        public Character LoadInitialCharacter();
    }
}
