namespace ProductListWithCart.Application.Interfaces
{
    public interface IMenuContext
    {
        public Task<List<T>> GetDesserts<T>(string table);
    }
}
