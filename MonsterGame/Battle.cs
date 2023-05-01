using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    internal class Battle : Foe //TODO Work out kinks
    {
        static Random BattleRNG = new Random();
        int EXP = 0;
        public void BeginBattle(int AreaType)
        {
            Foe CurrentFoe = GetFoe(AreaType, BattleRNG.Next(0,3));
            int FoeSPE = CurrentFoe.SPE;
            Console.WriteLine(CurrentFoe.Name + " appears");
            while (CurrentFoe != null && CurrentFoe.HP > 0)
            {
                int FoeATK = CurrentFoe.ATK;
                int Input = UI.DrawBattle();
                if (FoeSPE > Monsters.PlayerSPE)
                {
                    FoeATK -= Monsters.PlayerDEF;
                    if (FoeATK < 0) FoeATK = 1;
                    if (Input == 2) FoeATK = 0;
                    Console.WriteLine("Foe " + CurrentFoe.Name + " attacked for " + (FoeATK) + " amount of damage");
                }
                if (Input == 1)
                {
                    Console.WriteLine("Your monster attacked " + CurrentFoe.Name + "for " + Monsters.PlayerATK + " amount of damage!!");
                    CurrentFoe.HP -= Monsters.PlayerATK;
                    FoeSPE = CurrentFoe.SPE;
                    if (CurrentFoe.HP <= 0)
                    {
                        break;
                    }
                }
                if (FoeSPE < Monsters.PlayerSPE)
                {
                    FoeATK -= Monsters.PlayerDEF;
                    if (FoeATK < 0) FoeATK = 1;
                    if (Input == 2) FoeATK = 0;
                    Console.WriteLine("Foe " + CurrentFoe.Name + " attacked for " + (FoeATK) + " amount of damage");
                }
                if (Input == 2)
                {
                    Console.WriteLine("Your monster defended!");
                    Console.WriteLine("The foe became slower!");
                    FoeSPE = 0;
                }
            }
            if (Monsters.PlayerHP > 0)
            {
                Console.WriteLine("You win!");
                Console.WriteLine("Your monster gained " + CurrentFoe.EXP + "EXP");
                EXP += CurrentFoe.EXP;
                LevelUP();
            }
            void LevelUP()
            {
                if (EXP < 100)
                {
                    return;
                }
                Console.WriteLine("Your monster leveled up!!");
            }
        }
    }
}
