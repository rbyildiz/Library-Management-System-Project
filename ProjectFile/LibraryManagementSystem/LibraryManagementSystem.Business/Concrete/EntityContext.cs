using LibraryManagementSystem.Business.Abstract;
using LibraryManagementSystem.DataAccess.Abstract;
using LibraryManagementSystem.DataAccess.Concrete;
using LibraryManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Concrete
{
    public class EntityContext
    {
        private readonly string _connectionString;

        public IEntityManager<Book> Books { get => new EntityManager<Book>(new BookRepository(_connectionString)); }
        public IEntityManager<Author> Authors { get => new EntityManager<Author>(new AuthorRepository(_connectionString)); }
        public IEntityManager<BookMember> BookMembers { get => new EntityManager<BookMember>(new BookMemberRepository(_connectionString)); }
        public IEntityManager<Category> Categories { get => new EntityManager<Category>(new CategoryRepository(_connectionString)); }
        public IEntityManager<Member> Members { get => new EntityManager<Member>(new MemberRepository(_connectionString)); }

        public EntityContext(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString));

            _connectionString = connectionString;
        }
    }
}
