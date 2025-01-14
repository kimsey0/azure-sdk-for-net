// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class TimelineResultsMetadata
    {
        internal static TimelineResultsMetadata DeserializeTimelineResultsMetadata(JsonElement element)
        {
            int totalCount = default;
            IReadOnlyList<TimelineAggregation> aggregations = default;
            Optional<IReadOnlyList<TimelineError>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalCount"))
                {
                    totalCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("aggregations"))
                {
                    List<TimelineAggregation> array = new List<TimelineAggregation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimelineAggregation.DeserializeTimelineAggregation(item));
                    }
                    aggregations = array;
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TimelineError> array = new List<TimelineError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TimelineError.DeserializeTimelineError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new TimelineResultsMetadata(totalCount, aggregations, Optional.ToList(errors));
        }
    }
}
