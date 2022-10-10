namespace Algorithms
{
    static class Assignment_2
    {
        private static Random RNG = new Random();

        static string filePath = Path.Combine(Directory.GetCurrentDirectory(), "ChestLoot.txt");

        public static void FisherYatesShuffle(List<string> objects)
        {
            for (int i = objects.Count - 1; i > 0; i--)
            {
                int j = RNG.Next(i + 1); //Gets rendom number between the current index and 0
                string temp = objects[i];   //caches current index value
                objects[i] = objects[j]; //puts the random index value into current index
                objects[j] = temp;  //fills the random index with the cached current value
            }

            //in summary, this method will decrement through the given list, and swap the values from each index with
            //a random other index between 0 and the current index.
        }

        public static void DoExample()
        {
            string lootText = File.ReadAllText(filePath);
            List<string> loot = lootText.Split(",").ToList(); //parses list of loot into a list

            FisherYatesShuffle(loot);  //takes parsed list and shuffles it with the Fisher Yates method

            Console.WriteLine("Printing Randomized Loot list.");

            foreach(string s in loot)
            {
                Console.WriteLine(s);
            }
        }
    }
}
