using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwExtentionMethods.GameActors
{
    public class Player : IActor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int Point { get; set; }
        public Character PlayerCharacter { get; set; }
        public List<Map> PlayerMaps { get; set; }
        public List<Equipment> PlayerEquipments { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Level} - {Point}";
        }

        public int GameID { get; set; }
    }
}
