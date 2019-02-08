using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwExtentionMethods.GameActors
{
    public class Character : IActor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Power}";
        }

        public int GameID { get; set; }
    }
}
