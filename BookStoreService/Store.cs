using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    /// <summary>
    /// The store class.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Store : IStore
    {
        /// <summary>
        /// List of Books for storing books.
        /// </summary>
        private static readonly List<Book> books = new List<Book>();

        /// <summary>
        /// Adds a new book into books.
        /// </summary>
        /// <param name="book">The new book.</param>
        /// <returns>Returns the Result instance.</returns>
        public Result AddNewBook(Book book)
        {
            foreach(var item in books)
            {
                if(item.ID == book.ID)
                {
                    return new Result { Status = "Failure", Message = "The id of the book exists in library.", Books = null };
                }
            }
            books.Add(book);
            return new Result { Status = "Success", Message = "Book was added.", Books = new Book[] { book } };
        }

        /// <summary>
        /// Returns all books.
        /// </summary>
        /// <returns></returns>
        public Result GetAllBooks()
        {
            return new Result { Status = "Success", Message = $"Returned {books.Count()} books.", Books = books.ToArray() };
        }

        /// <summary>
        /// Changes the book's price.
        /// </summary>
        /// <param name="id">The id of the book.</param>
        /// <param name="price">he new price.</param>
        /// <returns></returns>
        public Result UpdateBookPrice(int id, double price)
        {
            int i;
            for (i = 0; i < books.Count(); i++)
            {
                if (books[i].ID == id)
                {
                    books[i].Price = price;
                    return new Result { Status = "Success", Message = "Price was changed.", Books = new Book[] { books[i] } };
                }
            }
            return new Result { Status = "Failure", Message = "The book with given id doesn't exist.", Books = null };
        }
    }
}
