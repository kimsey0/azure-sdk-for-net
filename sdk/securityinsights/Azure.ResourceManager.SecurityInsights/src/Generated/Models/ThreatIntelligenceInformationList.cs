// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of all the threat intelligence information objects. </summary>
    internal partial class ThreatIntelligenceInformationList
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceInformationList. </summary>
        /// <param name="value">
        /// Array of threat intelligence information objects.
        /// Please note <see cref="ThreatIntelligenceInformation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ThreatIntelligenceIndicatorData"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ThreatIntelligenceInformationList(IEnumerable<ThreatIntelligenceInformation> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ThreatIntelligenceInformationList. </summary>
        /// <param name="nextLink"> URL to fetch the next set of information objects. </param>
        /// <param name="value">
        /// Array of threat intelligence information objects.
        /// Please note <see cref="ThreatIntelligenceInformation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ThreatIntelligenceIndicatorData"/>.
        /// </param>
        internal ThreatIntelligenceInformationList(string nextLink, IReadOnlyList<ThreatIntelligenceInformation> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of information objects. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Array of threat intelligence information objects.
        /// Please note <see cref="ThreatIntelligenceInformation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ThreatIntelligenceIndicatorData"/>.
        /// </summary>
        public IReadOnlyList<ThreatIntelligenceInformation> Value { get; }
    }
}
