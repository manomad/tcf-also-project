using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Logging;
using TCF.Func.LicenseDataSynchronizer.Model;

namespace TCF.Func.LicenseDataSynchronizer.Helpers
{
    internal static class DbPersister
    {
        internal async static Task SyncronizeDataAsync(List<LicenseInfo> data, ILogger logger)
        {
			try
			{
                // Initialize Cosmos DB client with environment variables for configuration
                CosmosClient client = new CosmosClient(
                    accountEndpoint: Environment.GetEnvironmentVariable("CosmosDbAccountEndpoint"),
                    authKeyOrResourceToken: Environment.GetEnvironmentVariable("CosmosDbAuthKey"),
                    new CosmosClientOptions
                    {
                        SerializerOptions = new CosmosSerializationOptions { PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase },
                    }
                );

                // Get reference to the database and container
                Database database = client.GetDatabase(Environment.GetEnvironmentVariable("CosmosDbDatabaseName"));
                Container container = database.GetContainer(Environment.GetEnvironmentVariable("CosmosDbContainerName"));

                // Upsert each item in the data list into the Cosmos DB container
                foreach (var item in data)
                {
                    try
                    {
                        await container.UpsertItemAsync(item, new PartitionKey(item.Country));
                    }
                    catch (Exception ex)
                    {
                       logger.LogError(ex, "Error upserting item with id {Id} and country {Country}", item.Id, item.Country);
                    }
                }
            }
			catch (Exception ex)
			{
                logger.LogError(ex, "Error initializing Cosmos DB client or accessing database/container");
            }
        }
    }
}
