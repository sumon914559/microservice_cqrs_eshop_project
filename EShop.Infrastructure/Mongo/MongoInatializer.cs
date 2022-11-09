using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infrastructure.Mongo
{
    public class MongoInatializer : IDatabaseInitializer
    {
        private bool _initialized;
        private IMongoDatabase _database;
        public MongoInatializer(IMongoDatabase database)
        {
            _database = database;
        }

        public async Task InitializerAsync()
        {
            if (_initialized)
                return;
            IConventionPack conventionPack = new ConventionPack
            {
                new IgnoreExtraElementsConvention(true),
                new CamelCaseElementNameConvention(),
                new EnumRepresentationConvention(MongoDB.Bson.BsonType.String),
            };
            ConventionRegistry.Register("Eshop", conventionPack, c => true);

            _initialized = true;
            await Task.CompletedTask;
        }
    }
}
