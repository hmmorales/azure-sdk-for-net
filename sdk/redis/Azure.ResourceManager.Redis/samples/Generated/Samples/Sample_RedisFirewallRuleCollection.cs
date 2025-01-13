// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Redis.Samples
{
    public partial class Sample_RedisFirewallRuleCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RedisCacheFirewallRuleCreate()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheFirewallRuleCreate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisFirewallRuleResource
            RedisFirewallRuleCollection collection = redis.GetRedisFirewallRules();

            // invoke the operation
            string ruleName = "rule1";
            RedisFirewallRuleData data = new RedisFirewallRuleData(IPAddress.Parse("192.168.1.1"), IPAddress.Parse("192.168.1.4"));
            ArmOperation<RedisFirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, ruleName, data);
            RedisFirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisCacheFirewallRuleGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheFirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisFirewallRuleResource
            RedisFirewallRuleCollection collection = redis.GetRedisFirewallRules();

            // invoke the operation
            string ruleName = "rule1";
            RedisFirewallRuleResource result = await collection.GetAsync(ruleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisFirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RedisCacheFirewallRulesList()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheFirewallRulesList.json
            // this example is just showing the usage of "FirewallRules_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisFirewallRuleResource
            RedisFirewallRuleCollection collection = redis.GetRedisFirewallRules();

            // invoke the operation and iterate over the result
            await foreach (RedisFirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisFirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RedisCacheFirewallRuleGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheFirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisFirewallRuleResource
            RedisFirewallRuleCollection collection = redis.GetRedisFirewallRules();

            // invoke the operation
            string ruleName = "rule1";
            bool result = await collection.ExistsAsync(ruleName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RedisCacheFirewallRuleGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheFirewallRuleGet.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisFirewallRuleResource
            RedisFirewallRuleCollection collection = redis.GetRedisFirewallRules();

            // invoke the operation
            string ruleName = "rule1";
            NullableResponse<RedisFirewallRuleResource> response = await collection.GetIfExistsAsync(ruleName);
            RedisFirewallRuleResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisFirewallRuleData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
