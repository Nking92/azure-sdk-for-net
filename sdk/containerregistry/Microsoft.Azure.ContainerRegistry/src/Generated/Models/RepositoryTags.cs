// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of the request to list tags of the image
    /// </summary>
    public partial class RepositoryTags
    {
        /// <summary>
        /// Initializes a new instance of the RepositoryTags class.
        /// </summary>
        public RepositoryTags()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RepositoryTags class.
        /// </summary>
        /// <param name="name">Name of the image</param>
        /// <param name="tags">List of tags</param>
        public RepositoryTags(string name = default(string), IList<string> tags = default(IList<string>))
        {
            Name = name;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the image
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets list of tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
