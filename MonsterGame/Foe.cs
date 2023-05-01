using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    internal class Foe
    {
        public Foe()
        {
            Name = "NotGreg";
            ID = 0;
            HP = 1;
            ATK = 0;
            SPE = 0;
            EXP = 0;
        }
        protected internal string Name { get; set; }
        protected internal int ID { get; set; }
        protected internal int HP { get; set; }
        protected internal int ATK { get; set; }
        protected internal int SPE { get; set; }
        protected internal int EXP { get; set; }
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
        Random random = new Random();
        protected Foe GetFoe(int AreaType, int Num)
        {

            return Area1FoeList[Num];
        }
    }
}
