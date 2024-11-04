namespace ProductListWithCart.Application.Repositories
{
    public interface IDessertsRepository
    {
        public List<T> GetDesserts<T>(string table);
    }
}
