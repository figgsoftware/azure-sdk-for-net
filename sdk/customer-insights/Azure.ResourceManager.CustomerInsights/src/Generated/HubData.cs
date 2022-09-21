// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    /// <summary> A class representing the Hub data model. </summary>
    public partial class HubData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HubData. </summary>
        /// <param name="location"> The location. </param>
        public HubData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of HubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="apiEndpoint"> API endpoint URL of the hub. </param>
        /// <param name="webEndpoint"> Web endpoint URL of the hub. </param>
        /// <param name="provisioningState"> Provisioning state of the hub. </param>
        /// <param name="tenantFeatures"> The bit flags for enabled hub features. Bit 0 is set to 1 indicates graph is enabled, or disabled if set to 0. Bit 1 is set to 1 indicates the hub is disabled, or enabled if set to 0. </param>
        /// <param name="hubBillingInfo"> Billing settings of the hub. </param>
        internal HubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string apiEndpoint, string webEndpoint, string provisioningState, int? tenantFeatures, HubBillingInfoFormat hubBillingInfo) : base(id, name, resourceType, systemData, tags, location)
        {
            ApiEndpoint = apiEndpoint;
            WebEndpoint = webEndpoint;
            ProvisioningState = provisioningState;
            TenantFeatures = tenantFeatures;
            HubBillingInfo = hubBillingInfo;
        }

        /// <summary> API endpoint URL of the hub. </summary>
        public string ApiEndpoint { get; }
        /// <summary> Web endpoint URL of the hub. </summary>
        public string WebEndpoint { get; }
        /// <summary> Provisioning state of the hub. </summary>
        public string ProvisioningState { get; }
        /// <summary> The bit flags for enabled hub features. Bit 0 is set to 1 indicates graph is enabled, or disabled if set to 0. Bit 1 is set to 1 indicates the hub is disabled, or enabled if set to 0. </summary>
        public int? TenantFeatures { get; set; }
        /// <summary> Billing settings of the hub. </summary>
        public HubBillingInfoFormat HubBillingInfo { get; set; }
    }
}
