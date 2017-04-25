// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System.Linq;

    /// <summary>
    /// A multipart-numeric version number
    /// </summary>
    public partial class Version
    {
        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() { }

        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        /// <param name="major">the leftmost number of the version</param>
        /// <param name="minor">the second leftmost number of the
        /// version</param>
        /// <param name="build">the third number of the version</param>
        /// <param name="revision">the fourth number of the version</param>
        /// <param name="majorRevision">the MSW of the fourth part</param>
        /// <param name="minorRevision">the LSW of the fourth part</param>
        public Version(int? major = default(int?), int? minor = default(int?), int? build = default(int?), int? revision = default(int?), int? majorRevision = default(int?), int? minorRevision = default(int?))
        {
            Major = major;
            Minor = minor;
            Build = build;
            Revision = revision;
            MajorRevision = majorRevision;
            MinorRevision = minorRevision;
        }

        /// <summary>
        /// Gets or sets the leftmost number of the version
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "major")]
        public int? Major { get; set; }

        /// <summary>
        /// Gets or sets the second leftmost number of the version
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minor")]
        public int? Minor { get; set; }

        /// <summary>
        /// Gets or sets the third number of the version
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "build")]
        public int? Build { get; set; }

        /// <summary>
        /// Gets or sets the fourth number of the version
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// Gets or sets the MSW of the fourth part
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "majorRevision")]
        public int? MajorRevision { get; set; }

        /// <summary>
        /// Gets or sets the LSW of the fourth part
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "minorRevision")]
        public int? MinorRevision { get; set; }

    }
}