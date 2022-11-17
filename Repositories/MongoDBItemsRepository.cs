using CatalogAPI.Entities;
using MongoDB.Driver;

namespace CatalogAPI.Repositories
{
    public class MongoDBItemsRepository : IItemsRepository
    {
        private readonly string databaseName = "catalog";
        private readonly string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;
        public MongoDBItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName); 
        }

        public void CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}