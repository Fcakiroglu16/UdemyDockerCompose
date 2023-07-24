using MicroService1.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroService1.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{

		private readonly AppDbContext _context;
		private readonly IConfiguration _configuration;
		public ProductsController(AppDbContext context, IConfiguration configuration)
		{
			_context = context;
			_configuration = configuration;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{

			var httpClient = new HttpClient();

			var response = await httpClient.GetAsync($"{_configuration.GetSection("Microservices")["baseUrlMicroservice2"]}/api/products");

			var context= await response.Content.ReadAsStringAsync();

			return Ok(context);


		}


		[HttpPost]
		public IActionResult Save()
		{

			_context.Products.Add(new Product() { Name = "Pen 1" });
			_context.SaveChanges();
			return Ok();



		}
	}
}
