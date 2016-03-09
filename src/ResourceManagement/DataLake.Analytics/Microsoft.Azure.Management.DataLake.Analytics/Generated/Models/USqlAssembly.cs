// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL Assembly.
    /// </summary>
    public partial class USqlAssembly : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlAssembly class.
        /// </summary>
        public USqlAssembly() { }

        /// <summary>
        /// Initializes a new instance of the USqlAssembly class.
        /// </summary>
        public USqlAssembly(string computeAccountName = default(string), string version = default(string), string databaseName = default(string), string assemblyName = default(string), string clrName = default(string), bool? isVisible = default(bool?), bool? isUserDefined = default(bool?), IList<USqlAssemblyFileInfo> files = default(IList<USqlAssemblyFileInfo>), IList<USqlAssemblyDependencyInfo> dependencies = default(IList<USqlAssemblyDependencyInfo>))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            AssemblyName = assemblyName;
            ClrName = clrName;
            IsVisible = isVisible;
            IsUserDefined = isUserDefined;
            Files = files;
            Dependencies = dependencies;
        }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the assembly.
        /// </summary>
        [JsonProperty(PropertyName = "assemblyName")]
        public string AssemblyName { get; set; }

        /// <summary>
        /// Gets or sets the name of the CLR.
        /// </summary>
        [JsonProperty(PropertyName = "clrName")]
        public string ClrName { get; set; }

        /// <summary>
        /// Gets or sets the switch indicating if this assembly is visible or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "isVisible")]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// Gets or sets the switch indicating if this assembly is user
        /// defined or not.
        /// </summary>
        [JsonProperty(PropertyName = "isUserDefined")]
        public bool? IsUserDefined { get; set; }

        /// <summary>
        /// Gets or sets the list of files associated with the assembly
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<USqlAssemblyFileInfo> Files { get; set; }

        /// <summary>
        /// Gets or sets the list of dependencies associated with the assembly
        /// </summary>
        [JsonProperty(PropertyName = "dependencies")]
        public IList<USqlAssemblyDependencyInfo> Dependencies { get; set; }

    }
}
