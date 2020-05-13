using BrainDumpApi.Domain;
using MongoDB.Driver;

namespace BrainDumpApi
{
	public interface INoteContext
	{
		IMongoCollection<Note> Notes { get; }
	}
}
