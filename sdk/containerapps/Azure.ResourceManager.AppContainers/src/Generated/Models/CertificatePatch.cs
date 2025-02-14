// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> A certificate to update. </summary>
    public partial class CertificatePatch
    {
        /// <summary> Initializes a new instance of CertificatePatch. </summary>
        public CertificatePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
