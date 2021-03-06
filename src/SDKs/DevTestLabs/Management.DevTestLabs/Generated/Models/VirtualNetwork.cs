// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A virtual network.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetwork : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        /// <param name="id">The identifier of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="allowedSubnets">The allowed subnets of the virtual
        /// network.</param>
        /// <param name="description">The description of the virtual
        /// network.</param>
        /// <param name="externalProviderResourceId">The Microsoft.Network
        /// resource identifier of the virtual network.</param>
        /// <param name="externalSubnets">The external subnet
        /// properties.</param>
        /// <param name="subnetOverrides">The subnet overrides of the virtual
        /// network.</param>
        /// <param name="createdDate">The creation date of the virtual
        /// network.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public VirtualNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<Subnet> allowedSubnets = default(IList<Subnet>), string description = default(string), string externalProviderResourceId = default(string), IList<ExternalSubnet> externalSubnets = default(IList<ExternalSubnet>), IList<SubnetOverride> subnetOverrides = default(IList<SubnetOverride>), System.DateTime? createdDate = default(System.DateTime?), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(id, name, type, location, tags)
        {
            AllowedSubnets = allowedSubnets;
            Description = description;
            ExternalProviderResourceId = externalProviderResourceId;
            ExternalSubnets = externalSubnets;
            SubnetOverrides = subnetOverrides;
            CreatedDate = createdDate;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the allowed subnets of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowedSubnets")]
        public IList<Subnet> AllowedSubnets { get; set; }

        /// <summary>
        /// Gets or sets the description of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft.Network resource identifier of the
        /// virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalProviderResourceId")]
        public string ExternalProviderResourceId { get; set; }

        /// <summary>
        /// Gets the external subnet properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.externalSubnets")]
        public IList<ExternalSubnet> ExternalSubnets { get; private set; }

        /// <summary>
        /// Gets or sets the subnet overrides of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetOverrides")]
        public IList<SubnetOverride> SubnetOverrides { get; set; }

        /// <summary>
        /// Gets the creation date of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; private set; }

    }
}
