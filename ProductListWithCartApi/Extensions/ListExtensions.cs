using ProductListWithCart.Application.Models;

namespace ProductListWithCart.Application.Extensions
{
    internal static class ListExtensions
    {
        internal static DessertItemSuccessResponse ToSuccessResponse(this List<DessertItem> source)
        {
            return new DessertItemSuccessResponse()
            {
                Status = "success",
                Data = source
            };
        }
    }
}
