using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataModel
{
    class AuthorRepository : IRepository<Author>
    {
        private LibraryContext context;

        public AuthorRepository(LibraryContext context)
        {
            this.context = context;
        }

        public void Create(Author item)
        {
            context.Authors.Add(item);
        }

        public void Delete(int id)
        {
            Author author = context.Authors.Find(id);
            if (author != null)
            {
                context.Authors.Remove(author);
            }
        }

        public void Delete(Author item)
        {
            if (item != null)
                context.Authors.Remove(item);
        }

        public Author GetItem(int id)
        {
            return context.Authors.Find(id);
        }

        public IEnumerable<Author> GetList()
        {
            return context.Authors.ToList();
        }

        public void Update(Author item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
