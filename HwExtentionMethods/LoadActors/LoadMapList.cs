using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.LoadActors
{
    public static class LoadMapList
    {
        public static Map[] MapList()
        {
            Map[] players = new Map[]
            {
                new Map { ID = 1, Name = "Forest", MapScenario = null, DifficultyDegree = 10},
                new Map { ID = 2, Name = "Desert", MapScenario = null, DifficultyDegree = 20},
                new Map { ID = 3, Name = "Cave", MapScenario = null, DifficultyDegree = 30},
                new Map { ID = 4, Name = "Center", MapScenario = null, DifficultyDegree = 0}
            };
            return players;
        }
    }
}
