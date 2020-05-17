using Microsoft.AspNetCore.Mvc;

namespace BrainDumpApi.Controllers
{
	[Route("api/[controller]")]
	public class StatusController : ControllerBase
	{
		public IActionResult Index()
		{
			return Ok();
		}
	}
}
