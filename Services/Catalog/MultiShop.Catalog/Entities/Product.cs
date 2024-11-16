﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
	public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductIDd { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public string ProductImageUrl { get; set; }
		public string ProducDescription { get; set; }
		public string CategoryId { get; set; }

		[BsonIgnore] //MongoDB'ye kayıt iletmez. Category mongodbye gitmez.
		public Category Category { get; set; }

	}
}