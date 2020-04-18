using System.Threading.Tasks;

namespace UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Library> LibraryRepository { get; }
        IRepository<Book> BookRepository { get; }

        Task Commit();
    }
}