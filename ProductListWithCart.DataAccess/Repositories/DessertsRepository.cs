using ProductListWithCart.Application.Interfaces;
using ProductListWithCart.Application.Repositories;

namespace ProductListWithCart.DataAccess.Repositories
{
    public class DessertsRepository : IDessertsRepository
    {
        readonly IMenuContext _menuContext;
        public DessertsRepository(IMenuContext menuContext)
        {
            _menuContext = menuContext;
        }

        public async Task<List<T>> GetDesserts<T>(string table)
        {
            return await _menuContext.GetDesserts<T>(table);
        }

    }
}
