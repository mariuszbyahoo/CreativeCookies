using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCookies.Data
{
    /// <summary>
    /// Used only by the AzureCosmosDb
    /// </summary>
    public class DbClientFactory
    {
        //public static async Task<IPostsContext> InitializeCosmosClientInstanceAsync(IConfigurationSection configurationSection)
        //{
        //    string databaseName = configurationSection.GetSection("DatabaseName").Value;
        //    string containerName = configurationSection.GetSection("ContainerName").Value;
        //    string account = configurationSection.GetSection("Account").Value;
        //    string key = configurationSection.GetSection("Key").Value;
        //    CosmosClientBuilder clientBuilder = new CosmosClientBuilder(account, key);
        //    CosmosClient client = clientBuilder
        //                        .WithConnectionModeDirect()
        //                        .Build();
        //    IPostsContext cosmosDbContext = new PostsContext(client, databaseName, containerName);
        //    DatabaseResponse database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
        //    await database.Database.CreateContainerIfNotExistsAsync(containerName, "/id");

        //    return cosmosDbContext;
        //}
    }
}
