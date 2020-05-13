using System.Collections.Generic;
using System.Threading.Tasks;
using BrainDumpApi.Domain;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace BrainDumpApi.Controllers
{
	[Route("api/[controller]")]
	public class NotesController : ControllerBase
	{
		private readonly INoteContext context;

		public NotesController(INoteContext context)
		{
			this.context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Note>>> Get()
		{
			var all = await this.context.Notes.FindAsync(Builders<Note>.Filter.Empty);
			return Ok(all.ToList());
		}

		[HttpPost]
		public async Task<ActionResult<IEnumerable<Note>>> Post(Note note)
		{
			await this.context.Notes.InsertOneAsync(note);

			return Ok();
		}
	}
}
