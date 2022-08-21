using SQLite;

namespace HeroFormationOnMaui.Services
{
    public class SqliteDatabase
    {
        private readonly SQLiteAsyncConnection _connection;

        public SqliteDatabase()
        {
            var dataDir = FileSystem.AppDataDirectory;
            var databasePath = Path.Combine(dataDir, "HeroFormation.db");

            var dbEncryptionKey = SecureStorage.GetAsync("dbKey").Result;

            if (string.IsNullOrEmpty(dbEncryptionKey))
            {
                Guid g = new Guid();
                dbEncryptionKey = g.ToString();
                SecureStorage.SetAsync("dbKey", dbEncryptionKey);
            }

            var dbOptions = new SQLiteConnectionString(databasePath, true, key: dbEncryptionKey);
            _connection = new SQLiteAsyncConnection(dbOptions);
            _ = Initialise();
        }

        private async Task Initialise()
        {
            //await _connection.CreateTableAsync<>()
        }
    }
}
