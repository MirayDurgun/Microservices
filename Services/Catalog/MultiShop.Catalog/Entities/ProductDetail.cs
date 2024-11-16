using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Entities
{
	public class ProductDetailDetail
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductDetailIDd { get; set; }
		public string ProductDetailDescription { get; set; }
		public string ProductDetailInfo { get; set; }
		
	}
}
