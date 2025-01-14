// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Management RP details. </summary>
    public partial class ResourceProviderDetails
    {
        /// <summary> Initializes a new instance of <see cref="ResourceProviderDetails"/>. </summary>
        internal ResourceProviderDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceProviderDetails"/>. </summary>
        /// <param name="resourceProviderNamespace"> Resource provider namespace. </param>
        internal ResourceProviderDetails(string resourceProviderNamespace)
        {
            ResourceProviderNamespace = resourceProviderNamespace;
        }

        /// <summary> Resource provider namespace. </summary>
        public string ResourceProviderNamespace { get; }
    }
}
