// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAlertResourceIdentifier
    {
        internal static SecurityAlertResourceIdentifier DeserializeSecurityAlertResourceIdentifier(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureResource": return AzureResourceIdentifier.DeserializeAzureResourceIdentifier(element);
                    case "LogAnalytics": return LogAnalyticsIdentifier.DeserializeLogAnalyticsIdentifier(element);
                }
            }
            ResourceIdentifierType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new ResourceIdentifierType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSecurityAlertResourceIdentifier(type);
        }
    }
}
