// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> A copy activity source for Db2 databases. </summary>
    public partial class Db2Source : TabularSource
    {
        /// <summary> Initializes a new instance of Db2Source. </summary>
        public Db2Source()
        {
            Type = "Db2Source";
        }

        /// <summary> Initializes a new instance of Db2Source. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="queryTimeout"> Query timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects (or Expression with resultType array of objects). </param>
        /// <param name="query"> Database query. Type: string (or Expression with resultType string). </param>
        internal Db2Source(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object queryTimeout, IList<AdditionalColumns> additionalColumns, object query) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties, queryTimeout, additionalColumns)
        {
            Query = query;
            Type = type ?? "Db2Source";
        }

        /// <summary> Database query. Type: string (or Expression with resultType string). </summary>
        public object Query { get; set; }
    }
}
