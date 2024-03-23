namespace BookStore.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
