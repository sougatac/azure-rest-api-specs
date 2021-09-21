// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> A copy activity Azure Blob source. </summary>
    public partial class BlobSource : CopySource
    {
        /// <summary> Initializes a new instance of BlobSource. </summary>
        public BlobSource()
        {
            Type = "BlobSource";
        }

        /// <summary> Initializes a new instance of BlobSource. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="treatEmptyAsNull"> Treat empty as null. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="skipHeaderLineCount"> Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer). </param>
        /// <param name="recursive"> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </param>
        internal BlobSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object treatEmptyAsNull, object skipHeaderLineCount, object recursive) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            TreatEmptyAsNull = treatEmptyAsNull;
            SkipHeaderLineCount = skipHeaderLineCount;
            Recursive = recursive;
            Type = type ?? "BlobSource";
        }

        /// <summary> Treat empty as null. Type: boolean (or Expression with resultType boolean). </summary>
        public object TreatEmptyAsNull { get; set; }
        /// <summary> Number of header lines to skip from each blob. Type: integer (or Expression with resultType integer). </summary>
        public object SkipHeaderLineCount { get; set; }
        /// <summary> If true, files under the folder path will be read recursively. Default is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object Recursive { get; set; }
    }
}
