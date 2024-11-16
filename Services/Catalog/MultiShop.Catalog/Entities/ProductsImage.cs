﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
	public class ProductsImage
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductImageIDd { get; set; }
		public string ProductImage1 { get; set; }
		public string ProductImage2 { get; set; }
		public string ProductImage3 { get; set; }
		public string ProductId { get; set; }


		public Product Product { get; set; }

	}
}