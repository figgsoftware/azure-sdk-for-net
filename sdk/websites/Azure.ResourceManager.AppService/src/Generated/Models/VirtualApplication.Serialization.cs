// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VirtualApplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualPath))
            {
                writer.WritePropertyName("virtualPath");
                writer.WriteStringValue(VirtualPath);
            }
            if (Optional.IsDefined(PhysicalPath))
            {
                writer.WritePropertyName("physicalPath");
                writer.WriteStringValue(PhysicalPath);
            }
            if (Optional.IsDefined(IsPreloadEnabled))
            {
                writer.WritePropertyName("preloadEnabled");
                writer.WriteBooleanValue(IsPreloadEnabled.Value);
            }
            if (Optional.IsCollectionDefined(VirtualDirectories))
            {
                writer.WritePropertyName("virtualDirectories");
                writer.WriteStartArray();
                foreach (var item in VirtualDirectories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualApplication DeserializeVirtualApplication(JsonElement element)
        {
            Optional<string> virtualPath = default;
            Optional<string> physicalPath = default;
            Optional<bool> preloadEnabled = default;
            Optional<IList<VirtualDirectory>> virtualDirectories = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualPath"))
                {
                    virtualPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("physicalPath"))
                {
                    physicalPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preloadEnabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    preloadEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualDirectories"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VirtualDirectory> array = new List<VirtualDirectory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualDirectory.DeserializeVirtualDirectory(item));
                    }
                    virtualDirectories = array;
                    continue;
                }
            }
            return new VirtualApplication(virtualPath.Value, physicalPath.Value, Optional.ToNullable(preloadEnabled), Optional.ToList(virtualDirectories));
        }
    }
}
