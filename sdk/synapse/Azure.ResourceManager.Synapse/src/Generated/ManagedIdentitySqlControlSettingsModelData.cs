// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the ManagedIdentitySqlControlSettingsModel data model. </summary>
    public partial class ManagedIdentitySqlControlSettingsModelData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedIdentitySqlControlSettingsModelData. </summary>
        public ManagedIdentitySqlControlSettingsModelData()
        {
        }

        /// <summary> Initializes a new instance of ManagedIdentitySqlControlSettingsModelData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="grantSqlControlToManagedIdentity"> Grant sql control to managed identity. </param>
        internal ManagedIdentitySqlControlSettingsModelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedIdentitySqlControlSettingsModelPropertiesGrantSqlControlToManagedIdentity grantSqlControlToManagedIdentity) : base(id, name, resourceType, systemData)
        {
            GrantSqlControlToManagedIdentity = grantSqlControlToManagedIdentity;
        }

        /// <summary> Grant sql control to managed identity. </summary>
        public ManagedIdentitySqlControlSettingsModelPropertiesGrantSqlControlToManagedIdentity GrantSqlControlToManagedIdentity { get; set; }
    }
}
