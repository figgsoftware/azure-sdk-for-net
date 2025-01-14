// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> DataBox Disk Copy Progress. </summary>
    public partial class DataBoxDiskCopyProgress
    {
        /// <summary> Initializes a new instance of <see cref="DataBoxDiskCopyProgress"/>. </summary>
        internal DataBoxDiskCopyProgress()
        {
            Actions = new ChangeTrackingList<CustomerResolutionCode>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxDiskCopyProgress"/>. </summary>
        /// <param name="serialNumber"> The serial number of the disk. </param>
        /// <param name="bytesCopied"> Bytes copied during the copy of disk. </param>
        /// <param name="percentComplete"> Indicates the percentage completed for the copy of the disk. </param>
        /// <param name="status"> The Status of the copy. </param>
        /// <param name="error"> Error, if any, in the stage. </param>
        /// <param name="actions"> Available actions on the job. </param>
        internal DataBoxDiskCopyProgress(string serialNumber, long? bytesCopied, int? percentComplete, DataBoxCopyStatus? status, ResponseError error, IReadOnlyList<CustomerResolutionCode> actions)
        {
            SerialNumber = serialNumber;
            BytesCopied = bytesCopied;
            PercentComplete = percentComplete;
            Status = status;
            Error = error;
            Actions = actions;
        }

        /// <summary> The serial number of the disk. </summary>
        public string SerialNumber { get; }
        /// <summary> Bytes copied during the copy of disk. </summary>
        public long? BytesCopied { get; }
        /// <summary> Indicates the percentage completed for the copy of the disk. </summary>
        public int? PercentComplete { get; }
        /// <summary> The Status of the copy. </summary>
        public DataBoxCopyStatus? Status { get; }
        /// <summary> Error, if any, in the stage. </summary>
        public ResponseError Error { get; }
        /// <summary> Available actions on the job. </summary>
        public IReadOnlyList<CustomerResolutionCode> Actions { get; }
    }
}
