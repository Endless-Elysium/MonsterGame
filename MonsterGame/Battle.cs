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
           
        }
        static readonly private List<Foe> Area1FoeList = new List<Foe>
        {
            new Foe
            {
                Name = "Test 1", // Not working
                ID = 0,
                HP = 20,
                ATK = 1,
                SPE = 3,
                EXP = 2,
            },
            new Foe
            {
                Name = "Test 2",
                ID = 1,
                HP = 40,
                ATK = 1,
                SPE = 3,
                EXP = 50,
            },
            new Foe
            {
                Name = "Test 3",
                ID = 3,
                HP = 90,
                ATK = 1,
                SPE = 3,
                EXP = 100,
            },
        };
    }
}
