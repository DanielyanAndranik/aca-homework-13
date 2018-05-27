using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreService
{
    /// <summary>
    /// Defines a book class.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// An author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// A title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// A price of the book.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// A release year of the book.
        /// </summary>
        public int Year { get; set; }
    }
}
