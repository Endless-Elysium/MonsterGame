using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    internal class Field : Area
    {
        static readonly public List<Area> Fields = new List<Area>
        {
            new Area {Name = "Village", ID = 0, NextAreas = new int[4]
                {
                    1, 2, 3, 4
                },
                Foes = new int[1]
                {
                    0,
                }
            }
        };
        public Area CurrentArea { get; set; } = Fields[0];
    }
}
