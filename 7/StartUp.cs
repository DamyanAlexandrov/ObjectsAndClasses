using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ex2_ex
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            List<Book> books = new List<Book>();

            string pattern = @"(?<name>[A-z ]+)-(?<author>[A-z ]+)-(?<pages>\d+)";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < input.Length; i++)
            {
                var matches = regex.Matches(input[i]);

                foreach (Match match in matches)
                {
                    var name = match.Groups["name"].Value;
                    var author = match.Groups["author"].Value;
                    var pages = match.Groups["pages"].Value;

                    Book book = new Book();

                    /*foreach (var booki in books)
                    {
                        if (booki.Name.Contains(name) == false)
                        {
                            booki.Name = name;
                            booki.Author = author;
                            booki.Pages = int.Parse(pages);
                            books.Add(book);
                        }
                    }*/

                    book.Name = name;
                    book.Author = author;
                    book.Pages = int.Parse(pages);
                    books.Add(book);

                }

            }

            string bookToPrint = Console.ReadLine();

            foreach (var book in books)
            {
                if (book.Name == bookToPrint)
                {
                    Console.WriteLine($"Title: {book.Name} -> Written by: {book.Author} -> Volume: {book.Pages}");
                }

            }
        }
    }

    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
