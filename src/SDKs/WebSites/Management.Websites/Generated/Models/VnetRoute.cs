// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Virtual Network route contract used to pass routing information for a
    /// Virtual Network.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VnetRoute : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the VnetRoute class.
        /// </summary>
        public VnetRoute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VnetRoute class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="vnetRouteName">The name of this route. This is only
        /// returned by the server and does not need to be set by the
        /// client.</param>
        /// <param name="startAddress">The starting address for this route.
        /// This may also include a CIDR notation, in which case the end
        /// address must not be specified.</param>
        /// <param name="endAddress">The ending address for this route. If the
        /// start address is specified in CIDR notation, this must be
        /// omitted.</param>
        /// <param name="routeType">The type of route this is:
        /// DEFAULT - By default, every app has routes to the local address
        /// ranges specified by RFC1918
        /// INHERITED - Routes inherited from the real Virtual Network routes
        /// STATIC - Static route set on the app only
        ///
        /// These values will be used for syncing an app's routes with those
        /// from a Virtual Network. Possible values include: 'DEFAULT',
        /// 'INHERITED', 'STATIC'</param>
        public VnetRoute(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), string vnetRouteName = default(string), string startAddress = default(string), string endAddress = default(string), string routeType = default(string))
            : base(id, name, kind, type)
        {
            VnetRouteName = vnetRouteName;
            StartAddress = startAddress;
            EndAddress = endAddress;
            RouteType = routeType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of this route. This is only returned by the
        /// server and does not need to be set by the client.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string VnetRouteName { get; set; }

        /// <summary>
        /// Gets or sets the starting address for this route. This may also
        /// include a CIDR notation, in which case the end address must not be
        /// specified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startAddress")]
        public string StartAddress { get; set; }

        /// <summary>
        /// Gets or sets the ending address for this route. If the start
        /// address is specified in CIDR notation, this must be omitted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endAddress")]
        public string EndAddress { get; set; }

        /// <summary>
        /// Gets or sets the type of route this is:
        /// DEFAULT - By default, every app has routes to the local address
        /// ranges specified by RFC1918
        /// INHERITED - Routes inherited from the real Virtual Network routes
        /// STATIC - Static route set on the app only
        ///
        /// These values will be used for syncing an app's routes with those
        /// from a Virtual Network. Possible values include: 'DEFAULT',
        /// 'INHERITED', 'STATIC'
        /// </summary>
        [JsonProperty(PropertyName = "properties.routeType")]
        public string RouteType { get; set; }

    }
}
