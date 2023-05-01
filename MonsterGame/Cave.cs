using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    internal class Cave : Area
    {
        public Cave()
        {
            AreaType = 2;
        }
        static readonly public List<Area> Caves1 = new List<Area>
        {
            new Area {Name = "Room 1", ID = 0,
                NextAreas = new int[2] { 0, 1 },
            },
            new Area {Name = "Room 2", ID = 1,
                NextAreas = new int[2] { 0, 1 },
            },
        };
        public Area CurrentRoom { get; set; }

        public int GetCave(int id)
        {
            if (id == 5)
            {
                MoveRooms(Caves1);
                if (CurrentRoom.ID == 0)
                {
                    int i = UI.DrawLeaveCave();
                    return i;
                }
                return 0;
            }
            return 1;
        }
        List<Area> CurrentCave;
        public void MoveRooms(List<Area> Rooms)
        {
            if (CurrentRoom == null)
            {
                CurrentRoom = new Area();
                CurrentRoom = Rooms[0];
            }
            CurrentCave = Rooms;
            int NewRoom = UI.DrawMoveCaveSubArea(CurrentRoom, CurrentCave);
            CurrentRoom = Rooms[NewRoom];
        }
    }
}
