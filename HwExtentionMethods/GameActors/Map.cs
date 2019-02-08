using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwExtentionMethods.GameActors
{
    public class Map : IActor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DifficultyDegree { get; set; }
        public Scenario MapScenario { get; set; }
        public List<Equipment> MapsEquipments { get; set; }

        public override string ToString()
        {
            return $"{Name} - {MapScenario.Name}";
        }

        public int GameID { get; set; }
    }
}
