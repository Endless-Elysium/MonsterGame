using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Monster
    {
        protected internal string Name { get; set; }
        protected internal int Id { get; set; }
        protected internal int Stage { get; set; }
        protected internal int MaxHP { get; set; }
        protected internal int HP = 99;
        protected internal int Def { get; set; }
        protected internal int Atk { get; set; }
        protected internal int Spe { get; set; }


    }
}
