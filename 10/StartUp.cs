namespace Articles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Article article = new Article();

            string[] input = Console.ReadLine().Split(", ");

            article.Author = input[2];
            article.Title = input[0];
            article.Content = input[1];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] newParameters = Console.ReadLine().Split(": ");

                if (newParameters[0] == "Edit")
                {
                    article.Edit(newParameters[1]);
                }
                else if (newParameters[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(newParameters[1]);
                }
                else if (newParameters[0] == "Rename")
                {
                    article.Rename(newParameters[1]);
                }
            }

            Console.WriteLine(article.ToString());

        }
    }
    class Article
    {
        public string title;
        public string content;
        public string author;

        public string Title 
        {
            get { return title; }
            set { title = value; }
        }
        public string Content 
        {
            get { return content; } 
            set { content = value; }
        }
        public string Author 
        {
            get { return author; }
            set { author = value; }
        }

        public void Edit(string newContent)
        {
            content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            author = newAuthor;
        }

        public void Rename(string newName)
        {
            title = newName;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
