// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The LinkConnectionTargetDatabaseTypeProperties. </summary>
    public partial class LinkConnectionTargetDatabaseTypeProperties
    {
        /// <summary> Initializes a new instance of LinkConnectionTargetDatabaseTypeProperties. </summary>
        public LinkConnectionTargetDatabaseTypeProperties()
        {
        }

        /// <summary> Initializes a new instance of LinkConnectionTargetDatabaseTypeProperties. </summary>
        /// <param name="crossTableTransaction"> Enable cross table transaction consistency on target database. </param>
        /// <param name="dropExistingTargetTableOnStart"> Drop and recreate same existing target table on link connection target database. </param>
        /// <param name="actionOnExistingTargetTable"> Action on existing target table. If not specified, 'FailOnNonEmptyTable' action is used. </param>
        internal LinkConnectionTargetDatabaseTypeProperties(bool? crossTableTransaction, bool? dropExistingTargetTableOnStart, ActionOnExistingTargetTable? actionOnExistingTargetTable)
        {
            CrossTableTransaction = crossTableTransaction;
            DropExistingTargetTableOnStart = dropExistingTargetTableOnStart;
            ActionOnExistingTargetTable = actionOnExistingTargetTable;
        }

        /// <summary> Enable cross table transaction consistency on target database. </summary>
        public bool? CrossTableTransaction { get; set; }
        /// <summary> Drop and recreate same existing target table on link connection target database. </summary>
        public bool? DropExistingTargetTableOnStart { get; set; }
        /// <summary> Action on existing target table. If not specified, 'FailOnNonEmptyTable' action is used. </summary>
        public ActionOnExistingTargetTable? ActionOnExistingTargetTable { get; set; }
    }
}
