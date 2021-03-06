// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent
{
    /// <summary>
    /// Public IP address.
    /// </summary>
    public interface IPublicIPAddress  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.IGroupableResource<Microsoft.Azure.Management.Network.Fluent.INetworkManager,Models.PublicIPAddressInner>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IRefreshable<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IUpdatable<PublicIPAddress.Update.IUpdate>,
        Microsoft.Azure.Management.Network.Fluent.IUpdatableWithTags<Microsoft.Azure.Management.Network.Fluent.IPublicIPAddress>,
        Microsoft.Azure.Management.Network.Fluent.IPublicIPAddressBeta
    {
        /// <summary>
        /// Gets the assigned reverse FQDN, if any.
        /// </summary>
        string ReverseFqdn { get; }

        /// <summary>
        /// Gets the assigned FQDN (fully qualified domain name).
        /// </summary>
        string Fqdn { get; }

        /// <summary>
        /// Gets true if this public IP address is assigned to a network interface.
        /// </summary>
        bool HasAssignedNetworkInterface { get; }

        /// <summary>
        /// Gets the assigned IP address.
        /// </summary>
        string IPAddress { get; }

        /// <summary>
        /// Gets the IP address allocation method (Static/Dynamic).
        /// </summary>
        Models.IPAllocationMethod IPAllocationMethod { get; }

        /// <summary>
        /// Gets the idle connection timeout setting (in minutes).
        /// </summary>
        int IdleTimeoutInMinutes { get; }

        /// <summary>
        /// Gets the assigned leaf domain label.
        /// </summary>
        string LeafDomainLabel { get; }

        /// <return>The load balancer public frontend that this public IP address is assigned to.</return>
        Microsoft.Azure.Management.Network.Fluent.ILoadBalancerPublicFrontend GetAssignedLoadBalancerFrontend();

        /// <summary>
        /// Gets the IP version of the public IP address.
        /// </summary>
        Models.IPVersion Version { get; }

        /// <summary>
        /// Gets true if this public IP address is assigned to a load balancer.
        /// </summary>
        bool HasAssignedLoadBalancer { get; }

        /// <return>The network interface IP configuration that this public IP address is assigned to.</return>
        Microsoft.Azure.Management.Network.Fluent.INicIPConfiguration GetAssignedNetworkInterfaceIPConfiguration();
    }
}