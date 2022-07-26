// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceEnvironmentAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("virtualNetwork");
            writer.WriteObjectValue(VirtualNetwork);
            if (Optional.IsDefined(InternalLoadBalancingMode))
            {
                writer.WritePropertyName("internalLoadBalancingMode");
                writer.WriteStringValue(InternalLoadBalancingMode.Value.ToString());
            }
            if (Optional.IsDefined(MultiSize))
            {
                writer.WritePropertyName("multiSize");
                writer.WriteStringValue(MultiSize);
            }
            if (Optional.IsDefined(IPSslAddressCount))
            {
                writer.WritePropertyName("ipsslAddressCount");
                writer.WriteNumberValue(IPSslAddressCount.Value);
            }
            if (Optional.IsDefined(DnsSuffix))
            {
                writer.WritePropertyName("dnsSuffix");
                writer.WriteStringValue(DnsSuffix);
            }
            if (Optional.IsDefined(FrontEndScaleFactor))
            {
                writer.WritePropertyName("frontEndScaleFactor");
                writer.WriteNumberValue(FrontEndScaleFactor.Value);
            }
            if (Optional.IsCollectionDefined(ClusterSettings))
            {
                writer.WritePropertyName("clusterSettings");
                writer.WriteStartArray();
                foreach (var item in ClusterSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserWhitelistedIPRanges))
            {
                writer.WritePropertyName("userWhitelistedIpRanges");
                writer.WriteStartArray();
                foreach (var item in UserWhitelistedIPRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DedicatedHostCount))
            {
                writer.WritePropertyName("dedicatedHostCount");
                writer.WriteNumberValue(DedicatedHostCount.Value);
            }
            if (Optional.IsDefined(IsZoneRedundant))
            {
                writer.WritePropertyName("zoneRedundant");
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            writer.WriteEndObject();
        }

        internal static AppServiceEnvironmentAutoGenerated DeserializeAppServiceEnvironmentAutoGenerated(JsonElement element)
        {
            Optional<ProvisioningState> provisioningState = default;
            Optional<HostingEnvironmentStatus> status = default;
            VirtualNetworkProfile virtualNetwork = default;
            Optional<LoadBalancingMode> internalLoadBalancingMode = default;
            Optional<string> multiSize = default;
            Optional<int> multiRoleCount = default;
            Optional<int> ipsslAddressCount = default;
            Optional<string> dnsSuffix = default;
            Optional<int> maximumNumberOfMachines = default;
            Optional<int> frontEndScaleFactor = default;
            Optional<bool> suspended = default;
            Optional<IList<NameValuePair>> clusterSettings = default;
            Optional<IList<string>> userWhitelistedIPRanges = default;
            Optional<bool> hasLinuxWorkers = default;
            Optional<int> dedicatedHostCount = default;
            Optional<bool> zoneRedundant = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = property.Value.GetString().ToProvisioningState();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = property.Value.GetString().ToHostingEnvironmentStatus();
                    continue;
                }
                if (property.NameEquals("virtualNetwork"))
                {
                    virtualNetwork = VirtualNetworkProfile.DeserializeVirtualNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("internalLoadBalancingMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    internalLoadBalancingMode = new LoadBalancingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiSize"))
                {
                    multiSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiRoleCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    multiRoleCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ipsslAddressCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ipsslAddressCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnsSuffix"))
                {
                    dnsSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumNumberOfMachines"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maximumNumberOfMachines = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("frontEndScaleFactor"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    frontEndScaleFactor = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("suspended"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    suspended = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clusterSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NameValuePair> array = new List<NameValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NameValuePair.DeserializeNameValuePair(item));
                    }
                    clusterSettings = array;
                    continue;
                }
                if (property.NameEquals("userWhitelistedIpRanges"))
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
                    userWhitelistedIPRanges = array;
                    continue;
                }
                if (property.NameEquals("hasLinuxWorkers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasLinuxWorkers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dedicatedHostCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dedicatedHostCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("zoneRedundant"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AppServiceEnvironmentAutoGenerated(Optional.ToNullable(provisioningState), Optional.ToNullable(status), virtualNetwork, Optional.ToNullable(internalLoadBalancingMode), multiSize.Value, Optional.ToNullable(multiRoleCount), Optional.ToNullable(ipsslAddressCount), dnsSuffix.Value, Optional.ToNullable(maximumNumberOfMachines), Optional.ToNullable(frontEndScaleFactor), Optional.ToNullable(suspended), Optional.ToList(clusterSettings), Optional.ToList(userWhitelistedIPRanges), Optional.ToNullable(hasLinuxWorkers), Optional.ToNullable(dedicatedHostCount), Optional.ToNullable(zoneRedundant));
        }
    }
}
