// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Azure blobFS write settings. </summary>
    public partial class AzureBlobFSWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of AzureBlobFSWriteSettings. </summary>
        public AzureBlobFSWriteSettings()
        {
            Type = "AzureBlobFSWriteSettings";
        }

        /// <summary> Initializes a new instance of AzureBlobFSWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="blockSizeInMB"> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </param>
        internal AzureBlobFSWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties, object blockSizeInMB) : base(type, maxConcurrentConnections, copyBehavior, additionalProperties)
        {
            BlockSizeInMB = blockSizeInMB;
            Type = type ?? "AzureBlobFSWriteSettings";
        }

        /// <summary> Indicates the block size(MB) when writing data to blob. Type: integer (or Expression with resultType integer). </summary>
        public object BlockSizeInMB { get; set; }
    }
}
