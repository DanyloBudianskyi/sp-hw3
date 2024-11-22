using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace sp_hw3
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var books = await GetBooksAsync();
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id} Title: {book.Title}, Author: {book.Author}");
            }
            Console.ReadKey();
        }

        static async Task<List<Book>> GetBooksAsync()
        {
            using (var db = new LibraryDBEntities())
            {
                return await db.Books.ToListAsync();
            }
        }
    }
}
