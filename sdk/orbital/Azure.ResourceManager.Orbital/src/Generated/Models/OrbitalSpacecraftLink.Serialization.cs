// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    public partial class OrbitalSpacecraftLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("centerFrequencyMHz");
            writer.WriteNumberValue(CenterFrequencyMHz);
            writer.WritePropertyName("bandwidthMHz");
            writer.WriteNumberValue(BandwidthMHz);
            writer.WritePropertyName("direction");
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("polarization");
            writer.WriteStringValue(Polarization.ToString());
            writer.WriteEndObject();
        }

        internal static OrbitalSpacecraftLink DeserializeOrbitalSpacecraftLink(JsonElement element)
        {
            string name = default;
            float centerFrequencyMHz = default;
            float bandwidthMHz = default;
            OrbitalLinkDirection direction = default;
            OrbitalLinkPolarization polarization = default;
            Optional<IReadOnlyList<AuthorizedGroundStation>> authorizations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("centerFrequencyMHz"))
                {
                    centerFrequencyMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("bandwidthMHz"))
                {
                    bandwidthMHz = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("direction"))
                {
                    direction = new OrbitalLinkDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("polarization"))
                {
                    polarization = new OrbitalLinkPolarization(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authorizations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AuthorizedGroundStation> array = new List<AuthorizedGroundStation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AuthorizedGroundStation.DeserializeAuthorizedGroundStation(item));
                    }
                    authorizations = array;
                    continue;
                }
            }
            return new OrbitalSpacecraftLink(name, centerFrequencyMHz, bandwidthMHz, direction, polarization, Optional.ToList(authorizations));
        }
    }
}
