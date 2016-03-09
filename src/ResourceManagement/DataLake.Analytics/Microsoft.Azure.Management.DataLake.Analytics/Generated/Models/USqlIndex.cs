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
    /// A Data Lake Analytics catalog U-SQL table index item.
    /// </summary>
    public partial class USqlIndex
    {
        /// <summary>
        /// Initializes a new instance of the USqlIndex class.
        /// </summary>
        public USqlIndex() { }

        /// <summary>
        /// Initializes a new instance of the USqlIndex class.
        /// </summary>
        public USqlIndex(string name = default(string), IList<USqlDirectedColumn> indexKeys = default(IList<USqlDirectedColumn>), IList<string> columns = default(IList<string>), USqlDistributionInfo distributionInfo = default(USqlDistributionInfo), string partitionFunction = default(string), IList<string> partitionKeyList = default(IList<string>), IList<string> streamNames = default(IList<string>), bool? isColumnstore = default(bool?), int? indexId = default(int?), bool? isUnique = default(bool?))
        {
            Name = name;
            IndexKeys = indexKeys;
            Columns = columns;
            DistributionInfo = distributionInfo;
            PartitionFunction = partitionFunction;
            PartitionKeyList = partitionKeyList;
            StreamNames = streamNames;
            IsColumnstore = isColumnstore;
            IndexId = indexId;
            IsUnique = isUnique;
        }

        /// <summary>
        /// Gets or sets the name of the index in the table.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the list of directed columns in the index
        /// </summary>
        [JsonProperty(PropertyName = "indexKeys")]
        public IList<USqlDirectedColumn> IndexKeys { get; set; }

        /// <summary>
        /// Gets or sets the list of columns in the index
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public IList<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the distributions info of the index
        /// </summary>
        [JsonProperty(PropertyName = "distributionInfo")]
        public USqlDistributionInfo DistributionInfo { get; set; }

        /// <summary>
        /// Gets or sets partition function ID for the index.
        /// </summary>
        [JsonProperty(PropertyName = "partitionFunction")]
        public string PartitionFunction { get; set; }

        /// <summary>
        /// Gets or sets the list of partion keys in the index
        /// </summary>
        [JsonProperty(PropertyName = "partitionKeyList")]
        public IList<string> PartitionKeyList { get; set; }

        /// <summary>
        /// Gets or sets the list of full paths to the streams that contain
        /// this index in the DataLake account.
        /// </summary>
        [JsonProperty(PropertyName = "streamNames")]
        public IList<string> StreamNames { get; set; }

        /// <summary>
        /// Gets or sets the switch indicating if this index is a columnstore
        /// index.
        /// </summary>
        [JsonProperty(PropertyName = "isColumnstore")]
        public bool? IsColumnstore { get; set; }

        /// <summary>
        /// Gets or sets the ID of this index within the table.
        /// </summary>
        [JsonProperty(PropertyName = "indexId")]
        public int? IndexId { get; set; }

        /// <summary>
        /// Gets or sets the switch indicating if this index is a unique index.
        /// </summary>
        [JsonProperty(PropertyName = "isUnique")]
        public bool? IsUnique { get; set; }

    }
}
