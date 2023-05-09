using System;

namespace interface_mills_justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("M", "scifi shooter", "warframe");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movies myMovies = new Movies("PG", "Fantasy game", "super mario movie");
            Console.WriteLine(myMovies.Describe());
            myMovies.PlayMovies();

        }
    }
}
