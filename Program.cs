using Microsoft.EntityFrameworkCore;
using project1.Models;
using System.Linq;

namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManagementAppContext context = new LibraryManagementAppContext();

            //var author = new Author { Name = "Agatha Christie" };
//context.Authors.Add(author);
//context.SaveChanges();
//            var books = new List<Book>
//{
//              new Book { Title = "Murder on the Orient Express", PublishedYear = 1934, AuthorId = 1 },
//                 new Book { Title = "And Then There Were None", PublishedYear = 1939, AuthorId = 1 }
//};

//            context.Books.AddRange(books);



//            var author = new Author { Name = "Arthur Conan Doyle" };
//            var book = new Book { Title = "Sherlock Holmes: A Study in Scarlet", PublishedYear = 1887, Author = author };

//            context.Books.Add(book);

//var book = context.Books.FirstOrDefault(b => b.Id == 1);
//if (book != null)
//{
//    book.Title = "Updated Title";


//    context.SaveChanges();



//}



//var member = new Member { Id = 2, FullName = "Eman mahdy" };
//context.Entry(member).State = EntityState.Modified;
//context.SaveChanges();
//var booksByAuthor = context.Books.Where(b => b.AuthorId == 1).ToList();

//var bookIds = booksByAuthor.Select(b => b.Id).ToList();

//var relatedRecords = context.BookCheckouts.Where(bc => bookIds.Contains((int)bc.BookId)).ToList();

//context.BookCheckouts.RemoveRange(relatedRecords);
//context.Books.RemoveRange(booksByAuthor);
//context.SaveChanges();




//var booksWithAuthors = context.Books.Include(b => b.Author).ToList();
//foreach (var item in booksWithAuthors)
//{
//    Console.WriteLine(item.Author.Name);
//}
//var book = context.Books.FirstOrDefault();
//var authorName = book?.Author?.Name;
//var books = context.Books.AsNoTracking().ToList();

//var book = new Book { Id = 2, Title = "Updated Title" };
//context.Books.Attach(book);
//context.Entry(book).Property(b => b.Title).IsModified = true;
//context.SaveChanges();


//int authorId = 2;
//var books = context.Books.FromSqlRaw("EXEC GetBookByAuthorId @p0", authorId).ToList();
//var books2 = context.Books.FromSqlInterpolated($"EXEC GetBookByAuthorId {authorId}").ToList();
            
        }
    }
}
