// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Grafana.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Grafana
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Grafana. </summary>
    public static partial class GrafanaExtensions
    {
        private static MockableGrafanaArmClient GetMockableGrafanaArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableGrafanaArmClient(client0));
        }

        private static MockableGrafanaResourceGroupResource GetMockableGrafanaResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableGrafanaResourceGroupResource(client, resource.Id));
        }

        private static MockableGrafanaSubscriptionResource GetMockableGrafanaSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableGrafanaSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedGrafanaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedGrafanaResource.CreateResourceIdentifier" /> to create a <see cref="ManagedGrafanaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaArmClient.GetManagedGrafanaResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedGrafanaResource" /> object. </returns>
        public static ManagedGrafanaResource GetManagedGrafanaResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableGrafanaArmClient(client).GetManagedGrafanaResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GrafanaPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GrafanaPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="GrafanaPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaArmClient.GetGrafanaPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GrafanaPrivateEndpointConnectionResource" /> object. </returns>
        public static GrafanaPrivateEndpointConnectionResource GetGrafanaPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableGrafanaArmClient(client).GetGrafanaPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="GrafanaPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="GrafanaPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="GrafanaPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaArmClient.GetGrafanaPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="GrafanaPrivateLinkResource" /> object. </returns>
        public static GrafanaPrivateLinkResource GetGrafanaPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableGrafanaArmClient(client).GetGrafanaPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ManagedPrivateEndpointModelResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedPrivateEndpointModelResource.CreateResourceIdentifier" /> to create a <see cref="ManagedPrivateEndpointModelResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaArmClient.GetManagedPrivateEndpointModelResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedPrivateEndpointModelResource" /> object. </returns>
        public static ManagedPrivateEndpointModelResource GetManagedPrivateEndpointModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableGrafanaArmClient(client).GetManagedPrivateEndpointModelResource(id);
        }

        /// <summary>
        /// Gets a collection of ManagedGrafanaResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaResourceGroupResource.GetManagedGrafanas()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ManagedGrafanaResources and their operations over a ManagedGrafanaResource. </returns>
        public static ManagedGrafanaCollection GetManagedGrafanas(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableGrafanaResourceGroupResource(resourceGroupResource).GetManagedGrafanas();
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaResourceGroupResource.GetManagedGrafanaAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ManagedGrafanaResource>> GetManagedGrafanaAsync(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetMockableGrafanaResourceGroupResource(resourceGroupResource).GetManagedGrafanaAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaResourceGroupResource.GetManagedGrafana(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ManagedGrafanaResource> GetManagedGrafana(this ResourceGroupResource resourceGroupResource, string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetMockableGrafanaResourceGroupResource(resourceGroupResource).GetManagedGrafana(workspaceName, cancellationToken);
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaSubscriptionResource.GetManagedGrafanas(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedGrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ManagedGrafanaResource> GetManagedGrafanasAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableGrafanaSubscriptionResource(subscriptionResource).GetManagedGrafanasAsync(cancellationToken);
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableGrafanaSubscriptionResource.GetManagedGrafanas(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedGrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ManagedGrafanaResource> GetManagedGrafanas(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableGrafanaSubscriptionResource(subscriptionResource).GetManagedGrafanas(cancellationToken);
        }
    }
}
