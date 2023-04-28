namespace MonsterGame
{
    internal class Program
    {
        public static Monsters Monsters = new Monsters();
        public static Field Fields = new Field();
        static void Main(string[] args)
        {
            while (true)
            {
                UI.DrawArea();
                Monsters.Evolve();
                UI.DrawMonsterInfo();
                Console.ReadLine();
                
            }
        }
    }
}