// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Datadog.Models
{
    public partial class MonitoredResource
    {
        internal static MonitoredResource DeserializeMonitoredResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<bool> sendingMetrics = default;
            Optional<string> reasonForMetricsStatus = default;
            Optional<bool> sendingLogs = default;
            Optional<string> reasonForLogsStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingMetrics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendingMetrics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForMetricsStatus"))
                {
                    reasonForMetricsStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sendingLogs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sendingLogs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reasonForLogsStatus"))
                {
                    reasonForLogsStatus = property.Value.GetString();
                    continue;
                }
            }
            return new MonitoredResource(id.Value, Optional.ToNullable(sendingMetrics), reasonForMetricsStatus.Value, Optional.ToNullable(sendingLogs), reasonForLogsStatus.Value);
        }
    }
}
