namespace ex4_lab
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int movieCount = int.Parse(Console.ReadLine());

            List<Movie> moviesList = new List<Movie>();

            for (int i = 0; i < movieCount; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string genre = input[0];
                string name = input[1];
                string duration = input[2];

                Movie movie = new Movie();

                movie.Name = name;
                movie.Genre = genre;
                movie.Duration = duration;

                moviesList.Add(movie);
            }

            string genreToPrint = Console.ReadLine();

            foreach (var mo in moviesList)
            {
                if (mo.Genre == genreToPrint || genreToPrint == "all")
                {
                    Console.WriteLine(mo.Name);
                }
            }
        }
    }
    class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
    }
}
