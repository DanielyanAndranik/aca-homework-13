using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Client.ServiceReference1;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StoreClient();

            var result = client.AddNewBook(new Book() { ID = 1, Author = "Ando", Price = 10.5, Title = "Title", Year = 2015 });

            Console.WriteLine(result.Message);

            result = client.GetAllBooks();

            Console.WriteLine(result.Message);

            result = client.UpdateBookPrice(1, 20);

            Console.WriteLine(result.Message);

            Console.WriteLine(result.Books[0].Price);
        }
    }
}
