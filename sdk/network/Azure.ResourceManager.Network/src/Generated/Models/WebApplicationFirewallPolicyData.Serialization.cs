// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    public partial class WebApplicationFirewallPolicyData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicySettings))
            {
                writer.WritePropertyName("policySettings");
                writer.WriteObjectValue(PolicySettings);
            }
            if (Optional.IsCollectionDefined(CustomRules))
            {
                writer.WritePropertyName("customRules");
                writer.WriteStartArray();
                foreach (var item in CustomRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagedRules))
            {
                writer.WritePropertyName("managedRules");
                writer.WriteObjectValue(ManagedRules);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebApplicationFirewallPolicyData DeserializeWebApplicationFirewallPolicyData(JsonElement element)
        {
            Optional<string> etag = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            Optional<PolicySettings> policySettings = default;
            Optional<IList<WebApplicationFirewallCustomRule>> customRules = default;
            Optional<IReadOnlyList<ApplicationGatewayData>> applicationGateways = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<WebApplicationFirewallPolicyResourceState> resourceState = default;
            Optional<ManagedRulesDefinition> managedRules = default;
            Optional<IReadOnlyList<SubResource>> httpListeners = default;
            Optional<IReadOnlyList<SubResource>> pathBasedRules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
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
                        if (property0.NameEquals("policySettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            policySettings = PolicySettings.DeserializePolicySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("customRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<WebApplicationFirewallCustomRule> array = new List<WebApplicationFirewallCustomRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebApplicationFirewallCustomRule.DeserializeWebApplicationFirewallCustomRule(item));
                            }
                            customRules = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGateways"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayData> array = new List<ApplicationGatewayData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayData.DeserializeApplicationGatewayData(item));
                            }
                            applicationGateways = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            resourceState = new WebApplicationFirewallPolicyResourceState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            managedRules = ManagedRulesDefinition.DeserializeManagedRulesDefinition(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("httpListeners"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            httpListeners = array;
                            continue;
                        }
                        if (property0.NameEquals("pathBasedRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<SubResource> array = new List<SubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SubResource.DeserializeSubResource(item));
                            }
                            pathBasedRules = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebApplicationFirewallPolicyData(id, name.Value, type.Value, location.Value, Optional.ToDictionary(tags), etag.Value, policySettings.Value, Optional.ToList(customRules), Optional.ToList(applicationGateways), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceState), managedRules.Value, Optional.ToList(httpListeners), Optional.ToList(pathBasedRules));
        }
    }
}
