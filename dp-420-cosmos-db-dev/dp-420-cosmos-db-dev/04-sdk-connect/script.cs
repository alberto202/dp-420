using System;
using System.Linq;
using Microsoft.Azure.Cosmos;

string endpoint = "https://localhost:8081";
string key = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

CosmosClient client = new (endpoint, key);
AccountProperties account = await client.ReadAccountAsync();

Console.WriteLine($"Account Name:\t{account.Id}");

Console.WriteLine($"Primary Region:\t{account.WritableRegions.FirstOrDefault()?.Name}");