using WebApiDemo.Entities;

namespace WebApiDemo.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly ApplicationDbContext context;
        public BookRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public int AddBook(Book book)
        {
            int res = 0;
            context.Books.Add(book);
            res = context.SaveChanges();
            return res;
        }

        public int DeleteBook(int id)
        {
            int res = 0;
            var book = context.Books.Where(x => x.Id == id).FirstOrDefault();
            if(book != null)
            {
                book.IsActive = 0;
                res = context.SaveChanges();
            }
            return res;
        }

        public Book GetBookById(int id)
        {
            int result = 0;
            var book = context.Books.Where(x => x.Id == id).FirstOrDefault();
            return book;
        }
        public IEnumerable<Book> GetBooks()
        {
            return context.Books.Where(x => x.IsActive == 1).ToList();
        }

        public int UpdateBook(Book book)
        {
            int result = 0;
            var b = context.Books.Where(x => x.Id == book.Id).FirstOrDefault();
            if (b != null)
            {
                b.Name = book.Name;
                b.Author = book.Author;
                b.Price = book.Price;
                b.IsActive = 1;
                result = context.SaveChanges();
            }
            return result;

        }
    }
}
