namespace MonsterGame
{
    internal class Program
    {
        public static Monsters Monsters = new Monsters();
        static void Main(string[] args)
        {
            while (true)
            {
                Monsters.Evolve();
                UI.DrawMonsterInfo();
                Console.ReadLine();
            }
        }
    }
}