// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class AutomationRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("displayName");
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("order");
            writer.WriteNumberValue(Order);
            writer.WritePropertyName("triggeringLogic");
            writer.WriteObjectValue(TriggeringLogic);
            writer.WritePropertyName("actions");
            writer.WriteStartArray();
            foreach (var item in Actions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AutomationRuleData DeserializeAutomationRuleData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            string displayName = default;
            int order = default;
            AutomationRuleTriggeringLogic triggeringLogic = default;
            IList<AutomationRuleAction> actions = default;
            Optional<DateTimeOffset> lastModifiedTimeUtc = default;
            Optional<DateTimeOffset> createdTimeUtc = default;
            Optional<ClientInfo> lastModifiedBy = default;
            Optional<ClientInfo> createdBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("order"))
                        {
                            order = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("triggeringLogic"))
                        {
                            triggeringLogic = AutomationRuleTriggeringLogic.DeserializeAutomationRuleTriggeringLogic(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("actions"))
                        {
                            List<AutomationRuleAction> array = new List<AutomationRuleAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationRuleAction.DeserializeAutomationRuleAction(item));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            lastModifiedBy = ClientInfo.DeserializeClientInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("createdBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdBy = ClientInfo.DeserializeClientInfo(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AutomationRuleData(id, name, type, systemData.Value, displayName, order, triggeringLogic, actions, Optional.ToNullable(lastModifiedTimeUtc), Optional.ToNullable(createdTimeUtc), lastModifiedBy.Value, createdBy.Value, Optional.ToNullable(etag));
        }
    }
}
