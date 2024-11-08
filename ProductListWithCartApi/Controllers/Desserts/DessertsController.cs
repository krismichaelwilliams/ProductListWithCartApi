using Microsoft.AspNetCore.Mvc;
using ProductListWithCart.Application.Queries.Desserts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductListWithCart.Api.Controllers.Desserts
{
    [Route("desserts")]
    [ApiController]
    public class DessertsController : ControllerBase
    {
        private const string Desserts = "Desserts";
        private readonly IGetDesserts _getDesserts;

        public DessertsController(IGetDesserts getDesserts)
        {
            _getDesserts = getDesserts;
        }

        // GET: api/<DessertsController>
        [HttpGet]
        public async Task<IActionResult> GetDesserts()
        {
            var result = await _getDesserts.FromTable(Desserts);
            return Ok(result);
        }

    }
}
