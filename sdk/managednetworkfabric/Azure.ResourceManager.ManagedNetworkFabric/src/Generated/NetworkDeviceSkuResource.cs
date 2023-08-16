// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A Class representing a NetworkDeviceSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetworkDeviceSkuResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetworkDeviceSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetNetworkDeviceSku method.
    /// </summary>
    public partial class NetworkDeviceSkuResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkDeviceSkuResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string networkDeviceSkuName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkDeviceSkus/{networkDeviceSkuName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkDeviceSkuClientDiagnostics;
        private readonly NetworkDeviceSkusRestOperations _networkDeviceSkuRestClient;
        private readonly NetworkDeviceSkuData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceSkuResource"/> class for mocking. </summary>
        protected NetworkDeviceSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkDeviceSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkDeviceSkuResource(ArmClient client, NetworkDeviceSkuData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkDeviceSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkDeviceSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkDeviceSkuApiVersion);
            _networkDeviceSkuRestClient = new NetworkDeviceSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkDeviceSkuApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedNetworkFabric/networkDeviceSkus";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkDeviceSkuData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a Network Device SKU details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkDeviceSkus/{networkDeviceSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDeviceSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkDeviceSkuResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _networkDeviceSkuClientDiagnostics.CreateScope("NetworkDeviceSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _networkDeviceSkuRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a Network Device SKU details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkDeviceSkus/{networkDeviceSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkDeviceSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkDeviceSkuResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _networkDeviceSkuClientDiagnostics.CreateScope("NetworkDeviceSkuResource.Get");
            scope.Start();
            try
            {
                var response = _networkDeviceSkuRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
