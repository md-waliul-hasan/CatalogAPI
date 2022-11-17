namespace CatalogAPI.Settings
{
    public class MongoDbSettings
    {
        public string Host {get;set;}
        public int Port {get;set;}
        public string ConnectionSetring {
            get
            {
                return $"mongodb://{Host}:{Port}";
            }
        }
    }
}