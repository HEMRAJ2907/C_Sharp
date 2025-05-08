using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Library.Models
{
    public struct Book
    {
        public string Title;
        public string Author;

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }
}

namespace Library.Services
{
    using Library.Models;

    public class LibraryManager
    {
        public void IssueBook(Book b)
        {
            Console.WriteLine($"Issuing book: {b.Title} by {b.Author}");
        }
    }
}

 internal class Program
{
    public static void Main()
    {
        Library.Models.Book book = new Library.Models.Book
        {
            Title = "C# in Depth",
            Author = "Jon Skeet"
        };

        book.ShowDetails();

        Library.Services.LibraryManager manager = new Library.Services.LibraryManager();
        manager.IssueBook(book);
    }
}

