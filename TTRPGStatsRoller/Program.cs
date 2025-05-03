namespace TTRPGStatsRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome traveler! This is my tabletop role-playing game stats roller!");

            char redo;
            Random random = new Random();
            string[] stats = { "STRENGTH", "DEXTERITY", "CONSTITUTION", "INTELLIGENCE", "CHARISMA", "WISDOM" };
            int[] scores = new int[6];
            string[] classes = {"HIGHWAYMAN","BRIGAND","WILD ONE","DUELIST","PUGILIST","SURGEON","GAMBLER","PERFORMER","COWARD"};
            string[] background = {"HERMIT","SOLDIER","SCHOLAR","MADMAN","APOTHECARY","ALCHEMIST","FOLK HERO","NAIVE IDEALIST","PRISONER",
            "WASHED UP HERO", "FALLEN PATRICIAN","PARIAH","EXCOMMUNICATED FROM THE CLOTH", "HAUNTED"};
            string[] race = {"ROOTLING","HUMAN","DWARF","ELF","HALFLING","ORC","BUGBEAR","GOBLIN","TIEFLING","KOBOLD"};
            do
            {
                int classPick = random.Next(classes.Length);
                int backgroundPick = random.Next(background.Length);
                int racePick = random.Next(race.Length);
                for (int i = 0; i < 6; i++)
                {
                    int scoreResult = random.Next(1, 21);
                    scores[i] = scoreResult;
                }
                for(int i = 0;i < 6; i++)
                {
                    Console.WriteLine($"" + stats[i] + ": " + scores[i]);
                }

                Console.WriteLine($"CLASS: " + classes[classPick] + "\n" + 
                    "BACKGROUND: " + background[backgroundPick] +
                    "\nRACE: " + race[racePick]);

                Console.Write("\n\n\nWould you like to go again? (y/n): ");
                redo = Console.ReadKey().KeyChar;
            } while (redo == 'y' || redo == 'Y');
        }
    }
}
