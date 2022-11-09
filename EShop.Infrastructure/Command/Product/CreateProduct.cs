using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Infrastructure.Command.Product
{
    public class CreateProduct
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        
        public string ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public Guid CategoryId { get; set; }
    }
}
