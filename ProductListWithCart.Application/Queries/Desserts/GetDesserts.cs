using ProductListWithCart.Application.Models;
using ProductListWithCart.Application.Repositories;

namespace ProductListWithCart.Application.Queries.Desserts
{
    public class GetDesserts : IGetDesserts
    {
        private readonly IDessertsRepository _dessertsRepository;

        public GetDesserts(IDessertsRepository dessertsRepository)
        {
            _dessertsRepository = dessertsRepository;
        }

        public List<DessertItem> FromTable(string table)
        {
            return _dessertsRepository.GetDesserts<DessertItem>(table);
        }
    }
}
