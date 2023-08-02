// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> VirtualMachinePatchParameters represents the body of the request to patch the virtual machine. </summary>
    public partial class NetworkCloudVirtualMachinePatch
    {
        /// <summary> Initializes a new instance of NetworkCloudVirtualMachinePatch. </summary>
        public NetworkCloudVirtualMachinePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The credentials used to login to the image repository that has access to the specified image. </summary>
        public ImageRepositoryCredentials VmImageRepositoryCredentials { get; set; }
    }
}
