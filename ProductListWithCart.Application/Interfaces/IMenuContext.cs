namespace ProductListWithCart.Application.Interfaces
{
    public interface IMenuContext
    {
        public List<T> GetDesserts<T>(string table);
    }
}
