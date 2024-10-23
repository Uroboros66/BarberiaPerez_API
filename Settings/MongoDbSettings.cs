namespace BarberiaPerez_API.Settings
{
    public class MongoDbSettings: IMongoDbSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }

        string Token { get; set; }
    }
}
