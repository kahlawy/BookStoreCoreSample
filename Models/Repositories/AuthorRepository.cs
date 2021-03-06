using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreCoreSample.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        IList<Author> authors;

        public AuthorRepository()
        {
            authors = new List<Author>
            {
                 new Author { Id=1, FullName="Kahlawy Saber"},
                 new Author { Id=2, FullName="Khalid Salah"},
                 new Author { Id=3, FullName="Hany Mohamed"}
            };
           
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);

            authors.Remove(author);
        }

        public Author Find(int id)
        {
            var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newEntity)
        {
            var author = Find(id);
            author.FullName = newEntity.FullName;
        }
    }
}
