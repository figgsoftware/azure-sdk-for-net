// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> Properties specific to the monitor resource. </summary>
    public partial class MonitorProperties
    {
        /// <summary> Initializes a new instance of MonitorProperties. </summary>
        public MonitorProperties()
        {
        }

        /// <summary> Initializes a new instance of MonitorProperties. </summary>
        /// <param name="provisioningState"></param>
        /// <param name="monitoringStatus"> Flag specifying if the resource monitoring is enabled or disabled. </param>
        /// <param name="marketplaceSubscriptionStatus"> Flag specifying the Marketplace Subscription Status of the resource. If payment is not made in time, the resource will go in Suspended state. </param>
        /// <param name="datadogOrganizationProperties"> Datadog organization properties. </param>
        /// <param name="userInfo"> User info. </param>
        /// <param name="liftrResourceCategory"></param>
        /// <param name="liftrResourcePreference"> The priority of the resource. </param>
        internal MonitorProperties(ProvisioningState? provisioningState, MonitoringStatus? monitoringStatus, MarketplaceSubscriptionStatus? marketplaceSubscriptionStatus, DatadogOrganizationProperties datadogOrganizationProperties, UserInfo userInfo, LiftrResourceCategory? liftrResourceCategory, int? liftrResourcePreference)
        {
            ProvisioningState = provisioningState;
            MonitoringStatus = monitoringStatus;
            MarketplaceSubscriptionStatus = marketplaceSubscriptionStatus;
            DatadogOrganizationProperties = datadogOrganizationProperties;
            UserInfo = userInfo;
            LiftrResourceCategory = liftrResourceCategory;
            LiftrResourcePreference = liftrResourcePreference;
        }

        /// <summary> Gets the provisioning state. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Flag specifying if the resource monitoring is enabled or disabled. </summary>
        public MonitoringStatus? MonitoringStatus { get; set; }
        /// <summary> Flag specifying the Marketplace Subscription Status of the resource. If payment is not made in time, the resource will go in Suspended state. </summary>
        public MarketplaceSubscriptionStatus? MarketplaceSubscriptionStatus { get; }
        /// <summary> Datadog organization properties. </summary>
        public DatadogOrganizationProperties DatadogOrganizationProperties { get; set; }
        /// <summary> User info. </summary>
        public UserInfo UserInfo { get; set; }
        /// <summary> Gets the liftr resource category. </summary>
        public LiftrResourceCategory? LiftrResourceCategory { get; }
        /// <summary> The priority of the resource. </summary>
        public int? LiftrResourcePreference { get; }
    }
}
