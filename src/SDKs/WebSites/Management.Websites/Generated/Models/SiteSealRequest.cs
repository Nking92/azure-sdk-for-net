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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Site seal request.
    /// </summary>
    public partial class SiteSealRequest
    {
        /// <summary>
        /// Initializes a new instance of the SiteSealRequest class.
        /// </summary>
        public SiteSealRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SiteSealRequest class.
        /// </summary>
        /// <param name="lightTheme">Theme</param>
        /// <param name="locale">Locale</param>
        public SiteSealRequest(bool? lightTheme = default(bool?), string locale = default(string))
        {
            LightTheme = lightTheme;
            Locale = locale;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets theme
        /// </summary>
        [JsonProperty(PropertyName = "lightTheme")]
        public bool? LightTheme { get; set; }

        /// <summary>
        /// Gets or sets locale
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

    }
}
