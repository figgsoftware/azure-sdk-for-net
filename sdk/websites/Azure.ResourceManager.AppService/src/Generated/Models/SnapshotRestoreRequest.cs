// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Details about app recovery operation. </summary>
    public partial class SnapshotRestoreRequest : ResourceData
    {
        /// <summary> Initializes a new instance of SnapshotRestoreRequest. </summary>
        public SnapshotRestoreRequest()
        {
        }

        /// <summary> Initializes a new instance of SnapshotRestoreRequest. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="snapshotTime"> Point in time in which the app restore should be done, formatted as a DateTime string. </param>
        /// <param name="recoverySource">
        /// Optional. Specifies the web app that snapshot contents will be retrieved from.
        /// If empty, the targeted web app will be used as the source.
        /// </param>
        /// <param name="enabledOverwrite"> If &lt;code&gt;true&lt;/code&gt; the restore operation can overwrite source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="isRecoverConfiguration"> If true, site configuration, in addition to content, will be reverted. </param>
        /// <param name="isIgnoreConflictingHostNames">
        /// If true, custom hostname conflicts will be ignored when recovering to a target web app.
        /// This setting is only necessary when RecoverConfiguration is enabled.
        /// </param>
        /// <param name="useDRSecondary"> If true, the snapshot is retrieved from DRSecondary endpoint. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal SnapshotRestoreRequest(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string snapshotTime, SnapshotRecoverySource recoverySource, bool? enabledOverwrite, bool? isRecoverConfiguration, bool? isIgnoreConflictingHostNames, bool? useDRSecondary, string kind) : base(id, name, resourceType, systemData)
        {
            SnapshotTime = snapshotTime;
            RecoverySource = recoverySource;
            EnabledOverwrite = enabledOverwrite;
            IsRecoverConfiguration = isRecoverConfiguration;
            IsIgnoreConflictingHostNames = isIgnoreConflictingHostNames;
            UseDRSecondary = useDRSecondary;
            Kind = kind;
        }

        /// <summary> Point in time in which the app restore should be done, formatted as a DateTime string. </summary>
        public string SnapshotTime { get; set; }
        /// <summary>
        /// Optional. Specifies the web app that snapshot contents will be retrieved from.
        /// If empty, the targeted web app will be used as the source.
        /// </summary>
        public SnapshotRecoverySource RecoverySource { get; set; }
        /// <summary> If &lt;code&gt;true&lt;/code&gt; the restore operation can overwrite source app; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? EnabledOverwrite { get; set; }
        /// <summary> If true, site configuration, in addition to content, will be reverted. </summary>
        public bool? IsRecoverConfiguration { get; set; }
        /// <summary>
        /// If true, custom hostname conflicts will be ignored when recovering to a target web app.
        /// This setting is only necessary when RecoverConfiguration is enabled.
        /// </summary>
        public bool? IsIgnoreConflictingHostNames { get; set; }
        /// <summary> If true, the snapshot is retrieved from DRSecondary endpoint. </summary>
        public bool? UseDRSecondary { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
