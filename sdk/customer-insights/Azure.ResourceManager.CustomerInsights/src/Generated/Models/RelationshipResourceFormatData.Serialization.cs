// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CustomerInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CustomerInsights
{
    public partial class RelationshipResourceFormatData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Cardinality))
            {
                writer.WritePropertyName("cardinality");
                writer.WriteStringValue(Cardinality.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStartObject();
                foreach (var item in DisplayName)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStartObject();
                foreach (var item in Description)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ExpiryDateTimeUtc))
            {
                writer.WritePropertyName("expiryDateTimeUtc");
                writer.WriteStringValue(ExpiryDateTimeUtc.Value, "O");
            }
            if (Optional.IsCollectionDefined(Fields))
            {
                writer.WritePropertyName("fields");
                writer.WriteStartArray();
                foreach (var item in Fields)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LookupMappings))
            {
                writer.WritePropertyName("lookupMappings");
                writer.WriteStartArray();
                foreach (var item in LookupMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProfileType))
            {
                writer.WritePropertyName("profileType");
                writer.WriteStringValue(ProfileType);
            }
            if (Optional.IsDefined(RelatedProfileType))
            {
                writer.WritePropertyName("relatedProfileType");
                writer.WriteStringValue(RelatedProfileType);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RelationshipResourceFormatData DeserializeRelationshipResourceFormatData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<CardinalityType> cardinality = default;
            Optional<IDictionary<string, string>> displayName = default;
            Optional<IDictionary<string, string>> description = default;
            Optional<DateTimeOffset> expiryDateTimeUtc = default;
            Optional<IList<PropertyDefinition>> fields = default;
            Optional<IList<RelationshipTypeMapping>> lookupMappings = default;
            Optional<string> profileType = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<string> relationshipName = default;
            Optional<string> relatedProfileType = default;
            Optional<string> relationshipGuidId = default;
            Optional<Guid> tenantId = default;
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
                        if (property0.NameEquals("cardinality"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            cardinality = property0.Value.GetString().ToCardinalityType();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            displayName = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            description = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("expiryDateTimeUtc"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expiryDateTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("fields"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PropertyDefinition> array = new List<PropertyDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PropertyDefinition.DeserializePropertyDefinition(item));
                            }
                            fields = array;
                            continue;
                        }
                        if (property0.NameEquals("lookupMappings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<RelationshipTypeMapping> array = new List<RelationshipTypeMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RelationshipTypeMapping.DeserializeRelationshipTypeMapping(item));
                            }
                            lookupMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("profileType"))
                        {
                            profileType = property0.Value.GetString();
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
                        if (property0.NameEquals("relationshipName"))
                        {
                            relationshipName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relatedProfileType"))
                        {
                            relatedProfileType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("relationshipGuidId"))
                        {
                            relationshipGuidId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RelationshipResourceFormatData(id, name, type, systemData.Value, Optional.ToNullable(cardinality), Optional.ToDictionary(displayName), Optional.ToDictionary(description), Optional.ToNullable(expiryDateTimeUtc), Optional.ToList(fields), Optional.ToList(lookupMappings), profileType.Value, Optional.ToNullable(provisioningState), relationshipName.Value, relatedProfileType.Value, relationshipGuidId.Value, Optional.ToNullable(tenantId));
        }
    }
}
