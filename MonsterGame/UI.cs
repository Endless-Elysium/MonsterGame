namespace MonsterGame
{
    internal class UI
    {
        readonly static string[] StageNames = { "None", "Minor", "Basic", "Major", "Ultra" };
        static public void DrawMonsterInfo()
        {
            
            Console.WriteLine("-Monster stats-");
            Console.WriteLine("Name: " + Program.Monsters.CurrentMonster.Name);
            Console.WriteLine("Stage: " + Program.Monsters.CurrentMonster.Stage + " " + UI.StageNames[Program.Monsters.CurrentMonster.Stage]);
            Console.WriteLine("HP: " + Program.Monsters.CurrentMonster.MaxHP);
            Console.WriteLine("ATK: " + Program.Monsters.CurrentMonster.Atk);
            Console.WriteLine("DEF: " + Program.Monsters.CurrentMonster.Def);
            Console.WriteLine("SPE: " + Program.Monsters.CurrentMonster.Spe);
            Console.WriteLine("Possible Evolves: null, to be added");
        }
        public void DrawBattle()
        {

        }
        static public int DrawEvo(int id1, int id2, int id3)
        {
            int[] Id = {id1, id2, id3 };
            int result = -1;
            Console.WriteLine("!!!!!!!");
            Console.WriteLine(Program.Monsters.CurrentMonster.Name + " wants to evolve!!");
            Console.WriteLine("What should it evolve into?");
            if (id1 != -1)
            {
                Console.WriteLine("1. " + Program.Monsters.monstersList[Id[0]].Name);
                Console.WriteLine("   OldHP: " + Program.Monsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.Monsters.monstersList[Id[0]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.Monsters.CurrentMonster.Atk + " >>> NewATK: " + Program.Monsters.monstersList[Id[0]].Atk);
                Console.WriteLine("   OldDEF: " + Program.Monsters.CurrentMonster.Def + " >>> NewDEF: " + Program.Monsters.monstersList[Id[0]].Def);
                Console.WriteLine("   OldSPE: " + Program.Monsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.Monsters.monstersList[Id[0]].Spe);
            }
            if (id2 != -1)
            {
                Console.WriteLine("2. " + Program.Monsters.monstersList[Id[1]].Name);
                Console.WriteLine("   OldHP: " + Program.Monsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.Monsters.monstersList[Id[1]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.Monsters.CurrentMonster.Atk + " >>> NewATK: " + Program.Monsters.monstersList[Id[1]].Atk);
                Console.WriteLine("   OldDEF: " + Program.Monsters.CurrentMonster.Def + " >>> NewDEF: " + Program.Monsters.monstersList[Id[1]].Def);
                Console.WriteLine("   OldSPE: " + Program.Monsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.Monsters.monstersList[Id[1]].Spe);
            }
            if (id3 != -1)
            {
                Console.WriteLine("3. " + Program.Monsters.monstersList[Id[2]].Name);
                Console.WriteLine("   OldHP: " + Program.Monsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.Monsters.monstersList[Id[2]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.Monsters.CurrentMonster.Atk + " >>> NewATK: " + Program.Monsters.monstersList[Id[2]].Atk);
                Console.WriteLine("   OldDEF: " + Program.Monsters.CurrentMonster.Def + " >>> NewDEF: " + Program.Monsters.monstersList[Id[2]].Def);
                Console.WriteLine("   OldSPE: " + Program.Monsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.Monsters.monstersList[Id[2]].Spe);
            }
            int Input = -1;
            while (Input == -1)
            {
                Input = IntPlayerInput();
            }
            result = Id[Input - 1];
            Console.WriteLine("You picked " + Program.Monsters.monstersList[Id[Input - 1]].Name);
            return result;
        }
        static int IntPlayerInput()
        {
            int Input = -1;
            try
            {
                while (Input == -1)
                {
                    Input = Convert.ToInt32(Console.ReadLine());
                }
            } catch (Exception)
            {
                Console.WriteLine("Enter a number");
                return -1;
            }
            return Input;
        }

        static public void DrawArea()
        {
            Console.WriteLine(Program.Fields.CurrentArea.Name);
            Console.WriteLine(Program.Fields.CurrentArea.ID);
            Console.WriteLine(Program.Fields.CurrentArea.Foes[0]);
            Console.WriteLine(Program.Fields.CurrentArea.NextAreas[0]);
        }
    }
}
