// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices
{
    /// <summary> A class representing the DeviceProvisioningServicesPrivateLinkResource data model. </summary>
    public partial class DeviceProvisioningServicesPrivateLinkResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of DeviceProvisioningServicesPrivateLinkResourceData. </summary>
        /// <param name="properties"> The properties for a group information object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal DeviceProvisioningServicesPrivateLinkResourceData(DeviceProvisioningServicesPrivateLinkResourceProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DeviceProvisioningServicesPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties for a group information object. </param>
        internal DeviceProvisioningServicesPrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DeviceProvisioningServicesPrivateLinkResourceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The properties for a group information object. </summary>
        public DeviceProvisioningServicesPrivateLinkResourceProperties Properties { get; }
    }
}
