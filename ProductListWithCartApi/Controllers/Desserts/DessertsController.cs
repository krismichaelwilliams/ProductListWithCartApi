using Microsoft.AspNetCore.Mvc;
using ProductListWithCart.Application.Queries.Desserts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductListWithCart.Api.Controllers.Desserts
{
    [Route("desserts")]
    [ApiController]
    public class DessertsController : ControllerBase
    {
        private readonly IGetDesserts _getDesserts;

        public DessertsController(IGetDesserts getDesserts)
        {
            _getDesserts = getDesserts;
        }

        // GET: api/<DessertsController>
        [HttpGet]
        public IActionResult GetDesserts()
        {
            throw new NotImplementedException();
        }

    }
}
