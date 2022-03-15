using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCoreSample.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {

        List<Book> books;
        public BookRepository()
        {
            books = new List<Book>() {
             new Book{  Id=1, Title="Healty Food", Description="Good Book"},
             new Book{  Id=2, Title="Your Sports", Description="NO Details"},
             new Book{  Id=3, Title="Healty Life", Description="Good Book"}
            };

        }
        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newEntity)
        {
            var book = Find(id);

            book.Title = newEntity.Title;
            book.Description = newEntity.Description;
        }
    }
}
