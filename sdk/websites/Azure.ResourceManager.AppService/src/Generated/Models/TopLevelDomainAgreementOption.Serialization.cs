// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class TopLevelDomainAgreementOption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsIncludePrivacy))
            {
                writer.WritePropertyName("includePrivacy");
                writer.WriteBooleanValue(IsIncludePrivacy.Value);
            }
            if (Optional.IsDefined(IsForTransfer))
            {
                writer.WritePropertyName("forTransfer");
                writer.WriteBooleanValue(IsForTransfer.Value);
            }
            writer.WriteEndObject();
        }
    }
}
