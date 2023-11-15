// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing the VMwareCluster data model.
    /// Define the cluster.
    /// </summary>
    public partial class VMwareClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VMwareClusterData. </summary>
        /// <param name="location"> The location. </param>
        public VMwareClusterData(AzureLocation location) : base(location)
        {
            Statuses = new ChangeTrackingList<VMwareResourceStatus>();
            DatastoreIds = new ChangeTrackingList<string>();
            NetworkIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of VMwareClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this cluster resides. </param>
        /// <param name="moRefId"> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the cluster. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the cluster. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the cluster. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="usedMemoryGB"> Gets the used physical memory on the cluster in GB. </param>
        /// <param name="totalMemoryGB"> Gets the total amount of physical memory on the cluster in GB. </param>
        /// <param name="usedCpuMHz"> Gets the used CPU usage across all cores on the cluster in MHz. </param>
        /// <param name="totalCpuMHz"> Gets the max CPU usage across all cores on the cluster in MHz. </param>
        /// <param name="datastoreIds"> Gets the datastore ARM ids. </param>
        /// <param name="networkIds"> Gets the network ARM ids. </param>
        /// <param name="provisioningState"> Gets the provisioning state. </param>
        internal VMwareClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, IReadOnlyList<VMwareResourceStatus> statuses, string customResourceName, long? usedMemoryGB, long? totalMemoryGB, long? usedCpuMHz, long? totalCpuMHz, IReadOnlyList<string> datastoreIds, IReadOnlyList<string> networkIds, VMwareResourceProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            Statuses = statuses;
            CustomResourceName = customResourceName;
            UsedMemoryGB = usedMemoryGB;
            TotalMemoryGB = totalMemoryGB;
            UsedCpuMHz = usedCpuMHz;
            TotalCpuMHz = totalCpuMHz;
            DatastoreIds = datastoreIds;
            NetworkIds = networkIds;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this cluster resides. </summary>
        public string VCenterId { get; set; }
        /// <summary> Gets or sets the vCenter MoRef (Managed Object Reference) ID for the cluster. </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the cluster. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the cluster. </summary>
        public string MoName { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<VMwareResourceStatus> Statuses { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets the used physical memory on the cluster in GB. </summary>
        public long? UsedMemoryGB { get; }
        /// <summary> Gets the total amount of physical memory on the cluster in GB. </summary>
        public long? TotalMemoryGB { get; }
        /// <summary> Gets the used CPU usage across all cores on the cluster in MHz. </summary>
        public long? UsedCpuMHz { get; }
        /// <summary> Gets the max CPU usage across all cores on the cluster in MHz. </summary>
        public long? TotalCpuMHz { get; }
        /// <summary> Gets the datastore ARM ids. </summary>
        public IReadOnlyList<string> DatastoreIds { get; }
        /// <summary> Gets the network ARM ids. </summary>
        public IReadOnlyList<string> NetworkIds { get; }
        /// <summary> Gets the provisioning state. </summary>
        public VMwareResourceProvisioningState? ProvisioningState { get; }
    }
}
