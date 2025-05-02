namespace TTRPGStatsRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome traveler! This is my tabletop role-playing game stats roller!");

            char redo;

            string[] stats = { "STRENCH", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "CHARISMA", "WISDOM" };
            int[] scores = new int[6];

            do
            {
                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
