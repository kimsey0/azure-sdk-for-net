// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    internal static partial class ConnectorStateExtensions
    {
        public static string ToSerialString(this ConnectorState value) => value switch
        {
            ConnectorState.Creating => "Creating",
            ConnectorState.Created => "Created",
            ConnectorState.Ready => "Ready",
            ConnectorState.Expiring => "Expiring",
            ConnectorState.Deleting => "Deleting",
            ConnectorState.Failed => "Failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectorState value.")
        };

        public static ConnectorState ToConnectorState(this string value)
        {
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Creating;
            if (string.Equals(value, "Created", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Created;
            if (string.Equals(value, "Ready", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Ready;
            if (string.Equals(value, "Expiring", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Expiring;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Deleting;
            if (string.Equals(value, "Failed", StringComparison.InvariantCultureIgnoreCase)) return ConnectorState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ConnectorState value.");
        }
    }
}
