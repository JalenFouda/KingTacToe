using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KingTacToe;

namespace KingTacToe.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	
	public class KingController : ControllerBase
	{
		//private readonly VSPlay vSPlay;
		[HttpGet]
		public IActionResult Get()
		{
			return Ok("Hello World");
		}

		[HttpPost]
		public IActionResult Post()
		{
			return Ok("Hello World");
		}
	}
}
