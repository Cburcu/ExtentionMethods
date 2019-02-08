using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.LoadActors
{
    public static class LoadScenarioList
    {
        public static Scenario[] ScenarioList()
        {
            Scenario[] scenarios = new Scenario[]
            {
                new Scenario {ID = 1, Name = "Human Scenario", Time = 128 },
                new Scenario {ID = 2, Name = "Elf Scenario", Time = 120 },
                new Scenario {ID = 3, Name = "Ork Scenario", Time = 118 }
            };
            return scenarios;
        }
    }
}
