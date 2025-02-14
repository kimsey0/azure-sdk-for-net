// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBExcludedPath : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            writer.WriteEndObject();
        }

        internal static CosmosDBExcludedPath DeserializeCosmosDBExcludedPath(JsonElement element)
        {
            Optional<string> path = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
            }
            return new CosmosDBExcludedPath(path.Value);
        }
    }
}
