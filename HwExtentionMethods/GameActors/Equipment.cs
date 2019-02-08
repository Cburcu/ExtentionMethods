using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwExtentionMethods.GameActors
{
    public class Equipment : IActor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }

        public int GameID { get; set; }
    }
}
