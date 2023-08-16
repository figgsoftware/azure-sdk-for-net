// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Network;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_BastionHostResource
    {
        // Delete Bastion Host
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteBastionHost()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/BastionHostDelete.json
            // this example is just showing the usage of "BastionHosts_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BastionHostResource created on azure
            // for more information of creating BastionHostResource, please refer to the document of BastionHostResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string bastionHostName = "bastionhosttenant";
            ResourceIdentifier bastionHostResourceId = BastionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bastionHostName);
            BastionHostResource bastionHost = client.GetBastionHostResource(bastionHostResourceId);

            // invoke the operation
            await bastionHost.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get Bastion Host
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetBastionHost()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/BastionHostGet.json
            // this example is just showing the usage of "BastionHosts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BastionHostResource created on azure
            // for more information of creating BastionHostResource, please refer to the document of BastionHostResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string bastionHostName = "bastionhosttenant'";
            ResourceIdentifier bastionHostResourceId = BastionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bastionHostName);
            BastionHostResource bastionHost = client.GetBastionHostResource(bastionHostResourceId);

            // invoke the operation
            BastionHostResource result = await bastionHost.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BastionHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Patch Bastion Host
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_PatchBastionHost()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/BastionHostPatch.json
            // this example is just showing the usage of "BastionHosts_UpdateTags" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this BastionHostResource created on azure
            // for more information of creating BastionHostResource, please refer to the document of BastionHostResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string bastionHostName = "bastionhosttenant";
            ResourceIdentifier bastionHostResourceId = BastionHostResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, bastionHostName);
            BastionHostResource bastionHost = client.GetBastionHostResource(bastionHostResourceId);

            // invoke the operation
            NetworkTagsObject networkTagsObject = new NetworkTagsObject()
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2",
},
            };
            ArmOperation<BastionHostResource> lro = await bastionHost.UpdateAsync(WaitUntil.Completed, networkTagsObject);
            BastionHostResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            BastionHostData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all Bastion Hosts for a given subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetBastionHosts_ListAllBastionHostsForAGivenSubscription()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2023-04-01/examples/BastionHostListBySubscription.json
            // this example is just showing the usage of "BastionHosts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (BastionHostResource item in subscriptionResource.GetBastionHostsAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                BastionHostData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
