using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static MonsterGame.Field;

namespace MonsterGame
{
    internal class Field : Area
    {
        public FieldEntities fieldEntities = new FieldEntities();
        static readonly public List<Area> Fields = new List<Area>
        {
            new Area {Name = "Village", ID = 0,
                AreaType = 0,
                NextAreas = new int[4] { 1, 2, 3, 4 },
                Foes = new int[1] { 0 },
            },
            new Area {Name = "Northern Field", ID = 1,
                AreaType = 1,
                NextAreas = new int[4] { 0, 2, 3, 5 },
                Foes = new int[1] { 0 },
            },
            new Area {Name = "Eastern Field", ID = 2,
                AreaType = 1,
                NextAreas = new int[3] { 0, 1, 4 },
                Foes = new int[1] { 0 },
            },
            new Area {Name = "Western Field", ID = 3,
                AreaType = 1,
                NextAreas = new int[3] { 0, 1, 4 },
                Foes = new int[1] { 0 },
            },
            new Area {Name = "Southern Field", ID = 4,
                AreaType = 1,
                NextAreas = new int[3] { 0, 2, 3 },
                Foes = new int[1] { 0 },
            },
            new Area {Name = "Cave", ID = 5,
                AreaType = 2,
                NextAreas = new int[1] { 1 },
                Foes = new int[1] { 0 },
            },
        };
        public Area CurrentArea { get; set; }
        public void MoveAreas(int ID)
        {
            int NewArea = UI.DrawMoveArea(CurrentArea, Fields);
            CurrentArea.ID = CurrentArea.NextAreas[NewArea];
            CurrentArea = UpdateArea();
            UpdateEntities();
        }
        public Area UpdateArea()
        {
            if (CurrentArea == null)
            {
                CurrentArea = new Area();
            }
            CurrentArea = Fields[CurrentArea.ID];
            return CurrentArea;
        }
        private void UpdateEntities()
        {
            fieldEntities.WhatsOnTheField(CurrentArea);
        }
    }
}
