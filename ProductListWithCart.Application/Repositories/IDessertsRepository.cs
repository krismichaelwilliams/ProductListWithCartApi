namespace ProductListWithCart.Application.Repositories
{
    public interface IDessertsRepository
    {
        public Task<List<T>> GetDesserts<T>(string table);
    }
}
