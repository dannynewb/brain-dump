using BrainDumpApi.Domain;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BrainDumpApi
{
	public class NoteContext : INoteContext
	{
		private readonly IMongoDatabase database;

		public NoteContext(IOptions<Settings> settings)
		{
			var client = new MongoClient(settings.Value.ConnectionString);
			this.database = client.GetDatabase(settings.Value.Database);
		}

		public IMongoCollection<Note> Notes => this.database.GetCollection<Note>("Notes");
	}
}
