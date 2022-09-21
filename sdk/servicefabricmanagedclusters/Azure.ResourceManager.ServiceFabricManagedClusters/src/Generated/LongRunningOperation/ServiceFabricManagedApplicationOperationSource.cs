// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    internal class ServiceFabricManagedApplicationOperationSource : IOperationSource<ServiceFabricManagedApplicationResource>
    {
        private readonly ArmClient _client;

        internal ServiceFabricManagedApplicationOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceFabricManagedApplicationResource IOperationSource<ServiceFabricManagedApplicationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServiceFabricManagedApplicationData.DeserializeServiceFabricManagedApplicationData(document.RootElement);
            return new ServiceFabricManagedApplicationResource(_client, data);
        }

        async ValueTask<ServiceFabricManagedApplicationResource> IOperationSource<ServiceFabricManagedApplicationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServiceFabricManagedApplicationData.DeserializeServiceFabricManagedApplicationData(document.RootElement);
            return new ServiceFabricManagedApplicationResource(_client, data);
        }
    }
}
