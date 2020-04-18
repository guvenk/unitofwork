using System.Threading.Tasks;

namespace UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private Repository<Library> _libraryRepository;
        private Repository<Book> _bookRepository;

        public UnitOfWork(AppDbContext dbContext) => _dbContext = dbContext;

        public IRepository<Library> LibraryRepository => _libraryRepository ??= new Repository<Library>(_dbContext);
        public IRepository<Book> BookRepository => _bookRepository ??= new Repository<Book>(_dbContext);

        public async Task Commit() => await _dbContext.SaveChangesAsync();
    }
}