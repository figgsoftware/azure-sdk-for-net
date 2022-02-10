// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a time series database connection to Azure Data Explorer
    /// with data being sent via an EventHub.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureDataExplorer")]
    public partial class AzureDataExplorerConnectionProperties : TimeSeriesDatabaseConnectionProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataExplorerConnectionProperties class.
        /// </summary>
        public AzureDataExplorerConnectionProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureDataExplorerConnectionProperties class.
        /// </summary>
        /// <param name="adxResourceId">The resource ID of the Azure Data
        /// Explorer cluster.</param>
        /// <param name="adxEndpointUri">The URI of the Azure Data Explorer
        /// endpoint.</param>
        /// <param name="adxDatabaseName">The name of the Azure Data Explorer
        /// database.</param>
        /// <param name="eventHubEndpointUri">The URL of the EventHub namespace
        /// for identity-based authentication. It must include the protocol
        /// sb://</param>
        /// <param name="eventHubEntityPath">The EventHub name in the EventHub
        /// namespace for identity-based authentication.</param>
        /// <param name="eventHubNamespaceResourceId">The resource ID of the
        /// EventHub namespace.</param>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Provisioning', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled', 'Deleted', 'Warning', 'Suspending', 'Restoring',
        /// 'Moving', 'Disabled'</param>
        /// <param name="adxTableName">The name of the Azure Data Explorer
        /// table.</param>
        /// <param name="eventHubConsumerGroup">The EventHub consumer group to
        /// use when ADX reads from EventHub. Defaults to $Default.</param>
        public AzureDataExplorerConnectionProperties(string adxResourceId, string adxEndpointUri, string adxDatabaseName, string eventHubEndpointUri, string eventHubEntityPath, string eventHubNamespaceResourceId, string provisioningState = default(string), string adxTableName = default(string), string eventHubConsumerGroup = default(string))
            : base(provisioningState)
        {
            AdxResourceId = adxResourceId;
            AdxEndpointUri = adxEndpointUri;
            AdxDatabaseName = adxDatabaseName;
            AdxTableName = adxTableName;
            EventHubEndpointUri = eventHubEndpointUri;
            EventHubEntityPath = eventHubEntityPath;
            EventHubNamespaceResourceId = eventHubNamespaceResourceId;
            EventHubConsumerGroup = eventHubConsumerGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the Azure Data Explorer cluster.
        /// </summary>
        [JsonProperty(PropertyName = "adxResourceId")]
        public string AdxResourceId { get; set; }

        /// <summary>
        /// Gets or sets the URI of the Azure Data Explorer endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "adxEndpointUri")]
        public string AdxEndpointUri { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure Data Explorer database.
        /// </summary>
        [JsonProperty(PropertyName = "adxDatabaseName")]
        public string AdxDatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the Azure Data Explorer table.
        /// </summary>
        [JsonProperty(PropertyName = "adxTableName")]
        public string AdxTableName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the EventHub namespace for identity-based
        /// authentication. It must include the protocol sb://
        /// </summary>
        [JsonProperty(PropertyName = "eventHubEndpointUri")]
        public string EventHubEndpointUri { get; set; }

        /// <summary>
        /// Gets or sets the EventHub name in the EventHub namespace for
        /// identity-based authentication.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubEntityPath")]
        public string EventHubEntityPath { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the EventHub namespace.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubNamespaceResourceId")]
        public string EventHubNamespaceResourceId { get; set; }

        /// <summary>
        /// Gets or sets the EventHub consumer group to use when ADX reads from
        /// EventHub. Defaults to $Default.
        /// </summary>
        [JsonProperty(PropertyName = "eventHubConsumerGroup")]
        public string EventHubConsumerGroup { get; set; }

    }
}
