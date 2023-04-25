using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    internal class Monsters : Monster
    {
        readonly public List<Monster> monstersList = new List<Monster>
        {
            new Monster {Name = "DinoFlare", Id  = 0, Stage = 1, MaxHP = 18, Def = 8, Atk = 11, Spe = 8},
            new Monster {Name = "GigaDinoFlare", Id  = 1, Stage = 2, MaxHP = 30, Def = 12, Atk = 18, Spe = 10},
            new Monster {Name = "DinoInferno", Id  = 2, Stage = 3, MaxHP = 38, Def = 20, Atk = 28, Spe = 14},
            new Monster {Name = "FINALDINOFLAME", Id  = 3, Stage = 4, MaxHP = 55, Def = 32, Atk = 40, Spe = 22},

            new Monster {Name = "GigaFlamdragon", Id  = 4, Stage = 3, MaxHP = 36, Def = 19, Atk = 30, Spe = 10},
            new Monster {Name = "INFERNODRAGON", Id  = 5, Stage = 4, MaxHP = 50, Def = 28, Atk = 45, Spe = 18},

            new Monster {Name = "Magmasaurus", Id  = 6, Stage = 2, MaxHP = 28, Def = 16, Atk = 16, Spe = 8},
            new Monster {Name = "Volcanosaurus", Id  = 7, Stage = 3, MaxHP = 42, Def = 28, Atk = 21, Spe = 12},
            new Monster {Name = "GIGAVOLCANOSAURUS", Id  = 8, Stage = 4, MaxHP = 60, Def = 38, Atk = 30, Spe = 16},

            new Monster {Name = "Riptile", Id  = 9, Stage = 2, MaxHP = 22, Def = 8, Atk = 20, Spe = 16},
            new Monster {Name = "Slashtile", Id  = 10, Stage = 3, MaxHP = 28, Def = 12, Atk = 30, Spe = 25},
            new Monster {Name = "BLADETILE", Id  = 11, Stage = 4, MaxHP = 34, Def = 18, Atk = 55, Spe = 40},

            new Monster {Name = "ShieldGon", Id  = 12, Stage = 3, MaxHP = 28, Def = 30, Atk = 26, Spe = 12},
            new Monster {Name = "PROTECDRA", Id  = 13, Stage = 4, MaxHP = 32, Def = 35, Atk = 38, Spe = 20},

            new Monster {Name = "Mountainwy", Id  = 14, Stage = 3, MaxHP = 48, Def = 38, Atk = 14, Spe = 3},
            new Monster {Name = "EVERESTWY", Id  = 15, Stage = 4, MaxHP = 60, Def = 60, Atk = 22, Spe = 4},

            new Monster {Name = "ArmorGon", Id  = 16, Stage = 1, MaxHP = 18, Def = 18, Atk = 10, Spe = 6},
            new Monster {Name = "KnightWyvern", Id  = 17, Stage = 2, MaxHP = 32, Def = 22, Atk = 22, Spe = 12},
            new Monster {Name = "KnightDragon", Id  = 18, Stage = 3, MaxHP = 48, Def = 32, Atk = 32, Spe = 20},
            new Monster {Name = "QueenDragon", Id  = 19, Stage = 4, MaxHP = 80, Def = 60, Atk = 60, Spe = 40},

        };
        public Monster CurrentMonster { get; set; }
        public void Evolve()
        {
            if (CurrentMonster == null)
            {
                CurrentMonster = new Monster();
                CurrentMonster.Id = -1;
            }
            switch (CurrentMonster.Id)
            {
                case -1:
                    CurrentMonster = monstersList[0]; //Start
                    break;
                case 0: 
                    CurrentMonster = monstersList[UI.DrawEvo(1, 6, 9)]; // DinoFlame
                    break;
                case 1:
                    CurrentMonster = monstersList[UI.DrawEvo(2, 4, 7)]; // GigaDino
                    break;
                case 2:
                    CurrentMonster = monstersList[UI.DrawEvo(3, 5, 16)]; // DinoInferno
                    break;
                case 4:
                    CurrentMonster = monstersList[UI.DrawEvo(5, 3, 8)]; // FireGon
                    break;
                case 6:
                    CurrentMonster = monstersList[UI.DrawEvo(7, 10, 14)]; // Magma
                    break;
                case 7:
                    CurrentMonster = monstersList[UI.DrawEvo(8, 5, 15)]; // Large Magma
                    break;
                case 9:
                    CurrentMonster = monstersList[UI.DrawEvo(10, 12, 14)]; // Riptile
                    break;
                case 10:
                    CurrentMonster = monstersList[UI.DrawEvo(11, 13, 15)]; // Big Riptile
                    break;
                case 12:
                    CurrentMonster = monstersList[UI.DrawEvo(13, 11, 16)]; // ShieldGon
                    break;
                case 14:
                    CurrentMonster = monstersList[UI.DrawEvo(15, 8, 11)]; // Mountain
                    break;
                case 16:
                    CurrentMonster = monstersList[UI.DrawEvo(17, -1, -1)]; // ArmorGon
                    break;
                case 17:
                    CurrentMonster = monstersList[UI.DrawEvo(18, -1, -1)]; // Kinghtwy
                    break;
                case 18:
                    CurrentMonster = monstersList[UI.DrawEvo(19, -1, -1)]; // KightDragon
                    break;
            }
        }
    }
}
