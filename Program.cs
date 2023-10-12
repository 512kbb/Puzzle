namespace Puzzle;
class Program
{
    static void Main(string[] args)
    {
        static string TossCoin()
        {
            Console.WriteLine("Lanzando una moneda!");
            Random rand = new();
            int randomNumber = rand.Next(2);
            // Console.WriteLine(randomNumber);
            if (randomNumber == 1)
            {
                return "Cara";
            }
            return "Cruz";
        }

        static Double TossMultipleCoins(int num)
        {
            int timesHeads = 0;
            
            for (int x = 0; x < num; x++)
            {
                string coin = TossCoin();
                if (coin == "Cara")
                {
                    timesHeads += 1;
                }
                // Console.WriteLine($"{coin}, {timesHeads}");
            }
            // Console.WriteLine($"{timesHeads} / {num} = {timesHeads / num}");
            return timesHeads == 0 ? 0 : (Double)timesHeads / num;
        }

        static List<string> biggerNames(List<string> names)
        {
            List<string> newNames = new();
            foreach (string name in names)
            {
                if (name.Length > 5)
                {
                    newNames.Add(name);
                }
            }

            return newNames;
        }

        static List<string> ShuffleNames(List<string> names)
        {
            // fisher-yates shuffle algoritmo: https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
            Random rand = new();
            List<string> shuffledNames = new(names);
            int nameCount = shuffledNames.Count;
            while (nameCount > 1)
            {
                nameCount--;
                int randomNumber = rand.Next(nameCount + 1);
                string name = shuffledNames[randomNumber];
                shuffledNames[randomNumber] = shuffledNames[nameCount];
                shuffledNames[nameCount] = name;
                // Console.WriteLine($"{name}, {nameCount}");
            }
            return shuffledNames;
        }

        Console.WriteLine(TossCoin());
        foreach (string name in biggerNames(new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" })) {
            Console.WriteLine(name);
        }
        Console.WriteLine(TossMultipleCoins(10));
        foreach (string name in ShuffleNames(new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" }))
        {
            Console.WriteLine(name);
        }
    }

}
