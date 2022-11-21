using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStructure
{
    struct BookStruct
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public enum bookType
        {
            Magazine,Novel,ReferenceBook,Miscellaneous
        }

        public void acceptBookDetails(int Id, string tit, double pri)
        {
            this.bookId = Id;
            this.title = tit;
            this.price = pri;
        }
        public void displayBookDetails()
        {
            Console.WriteLine("Printing Book Details: ");
            Console.WriteLine("Book Id is : "+bookId);
            Console.WriteLine("Title of Book : "+ title);
            Console.WriteLine("Book Price : "+ price);

            int id = bookId % 4;
            switch (id)
            {
                case 1:
                    Console.WriteLine("Book Type : {0}", bookType.Magazine);
                    break;
                case 2:
                    Console.WriteLine("Book Type : {0}", bookType.Novel);
                    break;
                case 3:
                    Console.WriteLine("Book Type : {0}", bookType.ReferenceBook);
                    break;
                case 0:
                    Console.WriteLine("Book Type : {0}", bookType.Miscellaneous);
                    break;
            }
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            var book = new BookStruct();
            Console.WriteLine("Enter book Id ");
            book.bookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter book title ");
            book.title = Console.ReadLine();
            Console.WriteLine("Enter book price ");
            book.price = double.Parse(Console.ReadLine());
            book.acceptBookDetails(book.bookId, book.title, book.price);
            book.displayBookDetails();
            Console.ReadLine();
        }
    }

}
