// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> Error definition. </summary>
    internal partial class ErrorDefinition
    {
        /// <summary> Initializes a new instance of ErrorDefinition. </summary>
        internal ErrorDefinition()
        {
            Details = new ChangeTrackingList<ErrorDefinition>();
        }

        /// <summary> Service specific error code which serves as the substatus for the HTTP error code. </summary>
        public string Code { get; }
        /// <summary> Description of the error. </summary>
        public string Message { get; }
        /// <summary> Internal error details. </summary>
        public IReadOnlyList<ErrorDefinition> Details { get; }
    }
}
