using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Area
    {
        protected internal string Name { get; set; }
        protected internal int ID { get; set; }
        protected internal int AreaType { get; set; }
        protected internal int[] NextAreas { get; set; }
    }
}
