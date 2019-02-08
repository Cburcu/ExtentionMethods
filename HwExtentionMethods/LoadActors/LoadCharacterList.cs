using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.LoadActors
{
    public static class LoadCharacterList
    {
        public static Character[] CharacterList()
        {
            Character[] characters = new Character[]
            {
                new Character{ ID = 1, Name = "Human", Power = 50},
                new Character{ ID = 2, Name = "Elf", Power = 55 },
                new Character{ ID = 3, Name = "Ork", Power = 60 }
            };
            return characters;
        }
    }
}
