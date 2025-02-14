// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownDataProtectionBackupCopySetting. </summary>
    internal partial class UnknownDataProtectionBackupCopySetting : DataProtectionBackupCopySetting
    {
        /// <summary> Initializes a new instance of UnknownDataProtectionBackupCopySetting. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal UnknownDataProtectionBackupCopySetting(string objectType) : base(objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
