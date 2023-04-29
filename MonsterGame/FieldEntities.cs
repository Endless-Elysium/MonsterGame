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
        
        public void WhatsOnTheField(Area area)
        {
            // 0 = Village
            // 1 = Basic Field
            // 2 = Cave
            // 3 = Dungeon
            switch(area.AreaType)
            {
                case 0:
                    Village();
                    break;
                case 1:
                    Field();
                    break;
                case 2:
                    Cave();
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
            if (FieldRng.Next(6) == 5)
            {

            }
            return;
        }
        private void Cave()
        {
            if (FieldRng.Next(4) == 3)
            {
                
            }
            return;
        }
        private void Dungeon()
        {

        }


    }
}
