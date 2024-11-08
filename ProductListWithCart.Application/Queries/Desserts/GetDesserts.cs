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

        public async Task<List<DessertItem>> FromTable(string table)
        {
            return await _dessertsRepository.GetDesserts<DessertItem>(table);
        }
    }
}
