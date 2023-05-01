using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class FieldEntities
    {
        Random FieldRng = new Random();
        Battle Fbattle = new Battle();
        Cave Fcave = new Cave();
        int Id;
        
        public void WhatsOnTheField(Area area)
        {
            Console.WriteLine("TESTER");
            // 0 = Village
            // 1 = Basic Field
            // 2 = Cave
            // 3 = Dungeon
            Id = area.ID;
            switch(area.AreaType)
            {
                case 0:
                    Village();
                    break;
                case 1:
                    Field();
                    break;
                case 2:
                    CaveEntities();
                    break;
                case 3:
                    Dungeon();
                    break;
            }

        }
        private void Village()
        {
            // Village todo
        }
        private void Field()
        {
            if (true)//FieldRng.Next(6) == 5)
            {
                Fbattle.BeginBattle(1);
            }
            return;
        }
        private void CaveEntities()
        {
            if (Id == 5)
            {
                while(true)
                {
                    int i = Fcave.GetCave(Id);
                    int RoomID = Fcave.CurrentRoom.ID;
                    Console.WriteLine("Last room id: " + RoomID);
                    if (i == 1) break;
                }
            }
            return;
        }
        private void Dungeon()
        {

        }


    }
}
