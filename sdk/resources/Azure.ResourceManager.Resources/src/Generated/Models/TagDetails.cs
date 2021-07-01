// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Tag details. </summary>
    internal partial class TagDetails : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of TagDetails. </summary>
        internal TagDetails()
        {
            Values = new ChangeTrackingList<TagValue>();
        }

        /// <summary> The tag name. </summary>
        public string TagName { get; }
        /// <summary> The total number of resources that use the resource tag. When a tag is initially created and has no associated resources, the value is 0. </summary>
        public TagCount Count { get; }
        /// <summary> The list of tag values. </summary>
        public IReadOnlyList<TagValue> Values { get; }
    }
}
