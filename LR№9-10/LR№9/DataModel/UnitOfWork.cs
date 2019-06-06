using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel
{
    class UnitOfWork : IDisposable
    {
        private LibraryContext context = new LibraryContext();
        private BookRepository bookRepository;
        private AuthorRepository authorRepository;

        public BookRepository Books
        {
            get
            {
                if (bookRepository == null)
                    bookRepository = new BookRepository(context);
                return bookRepository;
            }
        }

        public AuthorRepository Authors
        {
            get
            {
                if (authorRepository == null)
                    authorRepository = new AuthorRepository(context);
                return authorRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
