using System;

namespace BookManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int booksN;
            string books;
            Book[] livros;

            Console.WriteLine("enter number of books");
            books = Console.ReadLine();
            booksN = Convert.ToInt32(books);

            livros = new Book[booksN];

            for (int i = 0; i < booksN; i++)
            {
                string title, author;
                Book obra;

                Console.Write("titulo: ");
                title = Console.ReadLine();

                Console.Write("autor: ");
                author = Console.ReadLine();

                obra = new Book(title, author);
                livros[i] = obra;
            }

            for (int i = 0; i < booksN; i++)
            {
                string title = livros[i].GetTitle();
                //string author = livros[i].GetAuthor();

                Console.WriteLine($"Titulo: {title} ({title.Length})");
                //Console.WriteLine($"Autor: {author}");
            }
        }
    }
}
