using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrainDumpApi.Controllers
{
	[Route("api/[controller]")]
	public class StatusController : ControllerBase
	{
		// GET: /<controller>/
		public IActionResult Index()
		{
			return Ok("Its ok mate lol testy lol");
		}
	}
}
