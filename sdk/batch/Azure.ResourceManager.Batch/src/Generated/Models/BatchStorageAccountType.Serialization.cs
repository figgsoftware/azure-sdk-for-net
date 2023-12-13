// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class BatchStorageAccountTypeExtensions
    {
        public static string ToSerialString(this BatchStorageAccountType value) => value switch
        {
            BatchStorageAccountType.StandardLrs => "Standard_LRS",
            BatchStorageAccountType.PremiumLrs => "Premium_LRS",
            BatchStorageAccountType.StandardSSDLRS => "StandardSSD_LRS",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchStorageAccountType value.")
        };

        public static BatchStorageAccountType ToBatchStorageAccountType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Standard_LRS")) return BatchStorageAccountType.StandardLrs;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Premium_LRS")) return BatchStorageAccountType.PremiumLrs;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "StandardSSD_LRS")) return BatchStorageAccountType.StandardSSDLRS;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BatchStorageAccountType value.");
        }
    }
}
