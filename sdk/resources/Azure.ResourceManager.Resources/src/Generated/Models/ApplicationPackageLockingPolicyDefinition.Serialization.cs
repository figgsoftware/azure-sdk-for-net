// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class ApplicationPackageLockingPolicyDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedActions))
            {
                writer.WritePropertyName("allowedActions");
                writer.WriteStartArray();
                foreach (var item in AllowedActions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationPackageLockingPolicyDefinition DeserializeApplicationPackageLockingPolicyDefinition(JsonElement element)
        {
            Optional<IList<string>> allowedActions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedActions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedActions = array;
                    continue;
                }
            }
            return new ApplicationPackageLockingPolicyDefinition(Optional.ToList(allowedActions));
        }
    }
}
