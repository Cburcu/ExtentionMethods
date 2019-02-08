using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwExtentionMethods.GameActors
{
    public class Scenario : IActor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int GameID { get; set; }
    }
}
