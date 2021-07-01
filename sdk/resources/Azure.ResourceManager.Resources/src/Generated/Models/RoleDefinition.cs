// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Role definition properties. </summary>
    internal partial class RoleDefinition : SubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of RoleDefinition. </summary>
        internal RoleDefinition()
        {
            Permissions = new ChangeTrackingList<Permission>();
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> The role definition name. </summary>
        public string Name { get; }
        /// <summary> If this is a service role. </summary>
        public bool? IsServiceRole { get; }
        /// <summary> Role definition permissions. </summary>
        public IReadOnlyList<Permission> Permissions { get; }
        /// <summary> Role definition assignable scopes. </summary>
        public IReadOnlyList<string> Scopes { get; }
    }
}
