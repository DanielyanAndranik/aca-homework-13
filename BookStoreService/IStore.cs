using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    /// <summary>
    /// The service interface.
    /// </summary>
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface IStore
    {
        /// <summary>
        /// Returns all books.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        Result GetAllBooks();

        /// <summary>
        /// Adds a new book.
        /// </summary>
        /// <param name="book">The new book.</param>
        /// <returns></returns>
        [OperationContract]
        Result AddNewBook(Book book);

        /// <summary>
        /// Changes the book's price.
        /// </summary>
        /// <param name="id">The book's id.</param>
        /// <param name="price">The new price.</param>
        /// <returns></returns>
        [OperationContract]
        Result UpdateBookPrice(int id, double price);
    }

    /// <summary>
    /// Contract structure for response data.
    /// </summary>
    [DataContract]
    public struct Result
    {
        /// <summary>
        /// The status of the response.
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// The message of the response.
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// The array of books.
        /// </summary>
        [DataMember]
        public Book[] Books { get; set; }
    }
}
