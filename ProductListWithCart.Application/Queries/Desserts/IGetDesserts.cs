using ProductListWithCart.Application.Models;

namespace ProductListWithCart.Application.Queries.Desserts
{
    public interface IGetDesserts
    {
        public List<DessertItem> FromTable(string table);
    }
}
