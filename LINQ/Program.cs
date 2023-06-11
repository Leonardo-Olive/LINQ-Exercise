using LINQ;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            { "Zelda", "Mario", "Street Fighter", "Mortal Kombat", "Alone in the Dark", "Resident Evil", "Star Wars","Harry Potter"};

            var orderBy = videoGames.OrderBy(x => x.Length);
            foreach (var game in orderBy)
            {
                Console.WriteLine($"{game}");
            }

           


        }

    }
}
