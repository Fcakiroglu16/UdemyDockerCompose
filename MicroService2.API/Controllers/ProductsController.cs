using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService2.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(new { id = 1, name = "Pencil 2(Microservice2)" });
		}
	}
}
