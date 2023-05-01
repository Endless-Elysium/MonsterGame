namespace MonsterGame
{
    internal class UI
    {
        readonly static string[] StageNames = { "None", "Minor", "Basic", "Major", "Ultra" };
        static public void DrawMonsterInfo()
        {
            
            Console.WriteLine("-Monster stats-");
            Console.WriteLine("Name: " + Program.PMonsters.CurrentMonster.Name);
            Console.WriteLine("Stage: " + Program.PMonsters.CurrentMonster.Stage + " " + UI.StageNames[Program.PMonsters.CurrentMonster.Stage]);
            Console.WriteLine("HP: " + Program.PMonsters.CurrentMonster.MaxHP);
            Console.WriteLine("ATK: " + Program.PMonsters.CurrentMonster.Atk);
            Console.WriteLine("DEF: " + Program.PMonsters.CurrentMonster.Def);
            Console.WriteLine("SPE: " + Program.PMonsters.CurrentMonster.Spe);
            Console.WriteLine("Possible Evolves: null, to be added");
        }
        static public int DrawEvo(int id1, int id2, int id3)
        {
            int[] Id = {id1, id2, id3 };
            int result = -1;
            Console.WriteLine("!!!!!!!");
            Console.WriteLine(Program.PMonsters.CurrentMonster.Name + " wants to evolve!!");
            Console.WriteLine("What should it evolve into?");
            if (id1 != -1)
            {
                Console.WriteLine("1. " + Program.PMonsters.monstersList[Id[0]].Name);
                Console.WriteLine("   OldHP: " + Program.PMonsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.PMonsters.monstersList[Id[0]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.PMonsters.CurrentMonster.Atk + " >>> NewATK: " + Program.PMonsters.monstersList[Id[0]].Atk);
                Console.WriteLine("   OldDEF: " + Program.PMonsters.CurrentMonster.Def + " >>> NewDEF: " + Program.PMonsters.monstersList[Id[0]].Def);
                Console.WriteLine("   OldSPE: " + Program.PMonsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.PMonsters.monstersList[Id[0]].Spe);
            }
            if (id2 != -1)
            {
                Console.WriteLine("2. " + Program.PMonsters.monstersList[Id[1]].Name);
                Console.WriteLine("   OldHP: " + Program.PMonsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.PMonsters.monstersList[Id[1]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.PMonsters.CurrentMonster.Atk + " >>> NewATK: " + Program.PMonsters.monstersList[Id[1]].Atk);
                Console.WriteLine("   OldDEF: " + Program.PMonsters.CurrentMonster.Def + " >>> NewDEF: " + Program.PMonsters.monstersList[Id[1]].Def);
                Console.WriteLine("   OldSPE: " + Program.PMonsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.PMonsters.monstersList[Id[1]].Spe);
            }
            if (id3 != -1)
            {
                Console.WriteLine("3. " + Program.PMonsters.monstersList[Id[2]].Name);
                Console.WriteLine("   OldHP: " + Program.PMonsters.CurrentMonster.MaxHP + " >>> NewHP: " + Program.PMonsters.monstersList[Id[2]].MaxHP);
                Console.WriteLine("   OldATK: " + Program.PMonsters.CurrentMonster.Atk + " >>> NewATK: " + Program.PMonsters.monstersList[Id[2]].Atk);
                Console.WriteLine("   OldDEF: " + Program.PMonsters.CurrentMonster.Def + " >>> NewDEF: " + Program.PMonsters.monstersList[Id[2]].Def);
                Console.WriteLine("   OldSPE: " + Program.PMonsters.CurrentMonster.Spe + " >>> NewSPE: " + Program.PMonsters.monstersList[Id[2]].Spe);
            }
            int Input = -1;
            while (Input == -1)
            {
                Input = IntPlayerInput();
            }
            if (Input > 3) 
            {
                Input = 3;
            }
            result = Id[Input - 1];
            Console.WriteLine("You picked " + Program.PMonsters.monstersList[Id[Input - 1]].Name);
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
        static string StringPlayerInput()
        {
            string Input = "";
            try
            {
                while (Input == "")
                {
                    Input = Console.ReadLine();
                }
            } catch(Exception)
            {
                Console.WriteLine("Enter something");
                return "";
            }
            return Input;
        }
        static public void DrawArea()
        {
            Console.WriteLine(Program.Pfield.CurrentArea.Name);
            Console.WriteLine(Program.Pfield.CurrentArea.ID);
            Console.WriteLine(Program.Pfield.CurrentArea.NextAreas[0]);
        }
        static public int DrawMoveArea(Area area, List<Area> fields)
        {
            Console.WriteLine("Where would you like to move to?");
            for (int i = 0; i < area.NextAreas.Length; i++)
            {
                Console.WriteLine("    " + (i + 1) + ". " + fields[area.NextAreas[i]].Name);
            }
            int Input = -1;
            while (Input == -1)
            {
                Input = IntPlayerInput();
            }
            if (Input > area.NextAreas.Length)
            {
                Input = area.NextAreas.Length;
            }
            return Input - 1;
        }
        static public int DrawLeaveCave()
        {
            Console.WriteLine("Leave? Y/N");
            string input = "";
            while (input == "") {
                input = StringPlayerInput();
            }
            input = input.ToLower();
            if (input == "y")
            {
                return 1;
            }
            return 0;
        }
        static public int DrawMoveCaveSubArea(Area area, List<Area> Caves)
        {
            Console.WriteLine("Where would you like to move to?");
            for (int i = 0; i < area.NextAreas.Length; i++)
            {
                Console.WriteLine("    " + (i + 1) + ". " + Caves[area.NextAreas[i]].Name);
            }
            int Input = -1;
            while (Input == -1)
            {
                Input = IntPlayerInput();
            }
            if (Input > area.NextAreas.Length)
            {
                Input = area.NextAreas.Length;
            }
            return Input - 1;
        }
        static public int DrawBattle()
        {
            Console.WriteLine("What whould you like to do?");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            int Input = -1;
            while (Input == -1)
            {
                Input = IntPlayerInput();
            }
            if (Input > 2)
            {
                Input = 2;
            }
            return Input;
        }
    }
}
