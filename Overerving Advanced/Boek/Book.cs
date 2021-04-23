using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boek
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        protected double price;

        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }


        public static Book TelOp(Book book1, Book book2)
        {
            Book omnibus = new Book();

            omnibus.Title = "Omnibus van " + book1.Author + ", " + book2.Author;
            omnibus.Price = (book1.Price + book2.Price) / 2;
            omnibus.ISBN = book1.ISBN + book2.ISBN + 10000000;
            return omnibus;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN:D8}) {Price:C}";
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || obj.GetType().BaseType != typeof(Book) && obj.GetType() != typeof(Book))
            {
                return false;
            }

            Book book = (Book)obj;

            if (ISBN == book.ISBN)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
