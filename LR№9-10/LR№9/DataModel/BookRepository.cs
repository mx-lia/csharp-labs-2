using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel
{
    class BookRepository : IRepository<Book>
    {
        private LibraryContext context;

        public BookRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Book item)
        {
            context.Books.Add(item);
        }

        public void Delete(int id)
        {
            Book book = context.Books.Find(id);
            if (book != null)
            {
                context.Books.Remove(book);
            }
        }

        public void Delete(Book item)
        {
            if (item != null)
                context.Books.Remove(item);
        }

        public Book GetItem(int id)
        {
            return context.Books.Find(id);
        }

        public IEnumerable<Book> GetList()
        {
            return context.Books.ToList();
        }

        public void Update(Book item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
