// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> Collection of Big Data pool information. </summary>
    public partial class BigDataPoolResourceInfoListResult
    {
        /// <summary> Initializes a new instance of BigDataPoolResourceInfoListResult. </summary>
        internal BigDataPoolResourceInfoListResult()
        {
            Value = new ChangeTrackingList<BigDataPoolResourceInfo>();
        }

        /// <summary> Initializes a new instance of BigDataPoolResourceInfoListResult. </summary>
        /// <param name="nextLink"> Link to the next page of results. </param>
        /// <param name="value"> List of Big Data pools. </param>
        internal BigDataPoolResourceInfoListResult(string nextLink, IReadOnlyList<BigDataPoolResourceInfo> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> Link to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> List of Big Data pools. </summary>
        public IReadOnlyList<BigDataPoolResourceInfo> Value { get; }
    }
}
