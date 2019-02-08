using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HwExtentionMethods.ExtentionMethods;
using HwExtentionMethods.GameActors;
using HwExtentionMethods.LoadActors;

namespace HwExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = LoadPlayerList.PlayerList();
            var characters = LoadCharacterList.CharacterList();
            var maps = LoadMapList.MapList();
            var scenarios = LoadScenarioList.ScenarioList();
            var equipments = LoadEquipmentList.EquipmentList();

            var playerEqu = players[3].AddParameter(equipments[1], "PlayerEquipments",
                p => p.PlayerEquipments.Count == 0);
            Console.WriteLine(playerEqu.ToString() + "  " + playerEqu.PlayerEquipments[0].ToString());

            var ply = players[1].Apply(characters[1], "PlayerCharacter", p => p.PlayerCharacter == null);

            Console.WriteLine(ply.ToString());

            var map = maps[1].Apply(scenarios[1], "MapScenario", p => p.MapScenario == null);
            Console.WriteLine(map.Name + " - " + map.MapScenario.Name);

            var playerList = players.Find(p => p.Level > 10 && p.Name.ToLower().StartsWith("f"));

            foreach (var p in playerList)
            {
                Console.WriteLine(p.ToString());
            }


            var characterList = characters.Find(c => c.Name.Equals("Elf"));

            foreach (var c in characterList)
            {
                Console.WriteLine("Character : {0}", c.Name);
            }

            var plyrs = players.Where(p => p.Level > 100);

            foreach (var p in plyrs)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadLine();
        }
    }
}
