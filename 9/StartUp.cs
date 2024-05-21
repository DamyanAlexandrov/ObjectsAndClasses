namespace Articles2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Article article = new Article();

                string[] input = Console.ReadLine().Split(", ");

                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                listOfArticles.Add(article);
            }

            foreach (var m in listOfArticles)
            {
                Console.WriteLine($"{m.Title} - {m.Content}: {m.Author}");
            }
        }
    }
    class Article
    {

        public string Title
        {
            get;
            set; 
        }
        public string Content
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
    }
}
