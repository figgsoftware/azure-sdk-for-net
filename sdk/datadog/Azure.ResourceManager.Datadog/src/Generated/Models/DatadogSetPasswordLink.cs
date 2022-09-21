// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Datadog.Models
{
    /// <summary> The DatadogSetPasswordLink. </summary>
    public partial class DatadogSetPasswordLink
    {
        /// <summary> Initializes a new instance of DatadogSetPasswordLink. </summary>
        internal DatadogSetPasswordLink()
        {
        }

        /// <summary> Initializes a new instance of DatadogSetPasswordLink. </summary>
        /// <param name="setPasswordLink"></param>
        internal DatadogSetPasswordLink(string setPasswordLink)
        {
            SetPasswordLink = setPasswordLink;
        }

        /// <summary> Gets the set password link. </summary>
        public string SetPasswordLink { get; }
    }
}
