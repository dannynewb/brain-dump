using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BrainDumpApi.Domain
{
	public class Note
	{
		[BsonId]
		public ObjectId InternalId { get; set; }

		public string Title { get; set; }

		public string Body { get; set; }

		public DateTime EditedOn { get; set; }

		[BsonDateTimeOptions]
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
	}
}
