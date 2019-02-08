using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods.LoadActors
{
    public static class LoadEquipmentList
    {
        public static Equipment[] EquipmentList()
        {
            Equipment[] equipments = new Equipment[]
            {
                new Equipment{ ID = 1, Name = "Armor"},
                new Equipment{ ID = 2, Name = "Spear"},
                new Equipment{ ID = 3, Name = "Shield"}
            };
            return equipments;
        }
    }
}
