using System.Collections.Generic;
using HwExtentionMethods.GameActors;

namespace HwExtentionMethods
{
    public static class LoadPlayerList
    {
        public static Player[] PlayerList()
        {
            Player[] players = new Player[]
            {
                new Player { ID = 1, Name = "Burcu", Level = 100, Point = 468456, PlayerEquipments = new List<Equipment>(), PlayerMaps = new List<Map>()},
                new Player { ID = 2, Name = "Cemile", Level = 10, Point = 8456,PlayerEquipments = new List<Equipment>(), PlayerMaps = new List<Map>()},
                new Player { ID = 3, Name = "Fatma", Level = 180, Point = 5468456,PlayerEquipments = new List<Equipment>(), PlayerMaps = new List<Map>()},
                new Player { ID = 4, Name = "Gamze", Level = 90, Point = 68456,PlayerEquipments = new List<Equipment>(), PlayerMaps = new List<Map>()},
                new Player { ID = 5, Name = "Yasemin", Level = 210, Point = 65468456,PlayerEquipments = new List<Equipment>(), PlayerMaps = new List<Map>()}
            };
            return players;
        }

    }
}
