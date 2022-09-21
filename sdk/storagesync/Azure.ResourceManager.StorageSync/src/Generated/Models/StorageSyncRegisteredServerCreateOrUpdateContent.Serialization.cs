// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncRegisteredServerCreateOrUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerCertificate))
            {
                writer.WritePropertyName("serverCertificate");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ServerCertificate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(ServerCertificate.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion");
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ServerOSVersion))
            {
                writer.WritePropertyName("serverOSVersion");
                writer.WriteStringValue(ServerOSVersion);
            }
            if (Optional.IsDefined(LastHeartbeat))
            {
                writer.WritePropertyName("lastHeartBeat");
                writer.WriteStringValue(LastHeartbeat);
            }
            if (Optional.IsDefined(ServerRole))
            {
                writer.WritePropertyName("serverRole");
                writer.WriteStringValue(ServerRole);
            }
            if (Optional.IsDefined(ClusterId))
            {
                writer.WritePropertyName("clusterId");
                writer.WriteStringValue(ClusterId.Value);
            }
            if (Optional.IsDefined(ClusterName))
            {
                writer.WritePropertyName("clusterName");
                writer.WriteStringValue(ClusterName);
            }
            if (Optional.IsDefined(ServerId))
            {
                writer.WritePropertyName("serverId");
                writer.WriteStringValue(ServerId.Value);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName");
                writer.WriteStringValue(FriendlyName);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageSyncRegisteredServerCreateOrUpdateContent DeserializeStorageSyncRegisteredServerCreateOrUpdateContent(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<BinaryData> serverCertificate = default;
            Optional<string> agentVersion = default;
            Optional<string> serverOSVersion = default;
            Optional<string> lastHeartbeat = default;
            Optional<string> serverRole = default;
            Optional<Guid> clusterId = default;
            Optional<string> clusterName = default;
            Optional<Guid> serverId = default;
            Optional<string> friendlyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serverCertificate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverCertificate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("agentVersion"))
                        {
                            agentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverOSVersion"))
                        {
                            serverOSVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastHeartBeat"))
                        {
                            lastHeartbeat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverRole"))
                        {
                            serverRole = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            clusterId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("clusterName"))
                        {
                            clusterName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            serverId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageSyncRegisteredServerCreateOrUpdateContent(id, name, type, systemData.Value, serverCertificate.Value, agentVersion.Value, serverOSVersion.Value, lastHeartbeat.Value, serverRole.Value, Optional.ToNullable(clusterId), clusterName.Value, Optional.ToNullable(serverId), friendlyName.Value);
        }
    }
}
