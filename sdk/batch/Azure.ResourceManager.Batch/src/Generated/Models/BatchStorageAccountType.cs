// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The storage account type for use in creating data disks or OS disk. </summary>
    public enum BatchStorageAccountType
    {
        /// <summary> The data disk / OS disk should use standard locally redundant storage. </summary>
        StandardLrs,
        /// <summary> The data disk / OS disk should use premium locally redundant storage. </summary>
        PremiumLrs,
        /// <summary> The data disk / OS disk should use standard SSD locally redundant storage. </summary>
        StandardSSDLRS
    }
}
