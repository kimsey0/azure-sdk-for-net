// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Grafana
{
    /// <summary> A class representing the GrafanaPrivateEndpointConnection data model. </summary>
    public partial class GrafanaPrivateEndpointConnectionData : ResourceData
    {
        /// <summary> Initializes a new instance of GrafanaPrivateEndpointConnectionData. </summary>
        public GrafanaPrivateEndpointConnectionData()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GrafanaPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpoint"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="groupIds"> The private endpoint connection group ids. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        internal GrafanaPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SubResource privateEndpoint, GrafanaPrivateLinkServiceConnectionState connectionState, IList<string> groupIds, GrafanaPrivateEndpointConnectionProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            PrivateEndpoint = privateEndpoint;
            ConnectionState = connectionState;
            GroupIds = groupIds;
            ProvisioningState = provisioningState;
        }

        /// <summary> The resource of private end point. </summary>
        internal SubResource PrivateEndpoint { get; set; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint is null ? default : PrivateEndpoint.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        public GrafanaPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The private endpoint connection group ids. </summary>
        public IList<string> GroupIds { get; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        public GrafanaPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
