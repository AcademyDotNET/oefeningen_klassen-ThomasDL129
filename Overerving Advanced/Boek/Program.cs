using System;

namespace Boek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book book = new Book();
            book.ISBN = 100;

            Textbook textbook = new Textbook();
            textbook.ISBN = 100;

            Console.WriteLine(book.Equals(textbook));
            Console.WriteLine(textbook.Equals(book));

            textbook.Author = "Stephen King";
            textbook.Title = "The Shining";
            textbook.Price = 150;
            Console.WriteLine(textbook.ToString());


            CoffeeTableBook coffeeTableBook = new CoffeeTableBook();
            coffeeTableBook.ISBN = 100;

            Console.WriteLine(textbook.Equals(coffeeTableBook));

            Book omnibus = Book.TelOp(textbook, textbook);
            Console.WriteLine(omnibus);
        }
    }
}
