using ProductListWithCart.Application.Interfaces;
using ProductListWithCart.Application.Repositories;

namespace ProductListWithCart.DataAccess.Repositories
{
    internal class DessertsRepository : IDessertsRepository
    {
        readonly IMenuContext _menuContext;
        public DessertsRepository(IMenuContext menuContext)
        {
            _menuContext = menuContext;
        }

        public List<T> GetDesserts<T>(string table)
        {
            return _menuContext.GetDesserts<T>(table);
        }

    }
}
