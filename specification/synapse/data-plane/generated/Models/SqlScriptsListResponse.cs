// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtifactsClient.Models
{
    /// <summary> A list of sql scripts resources. </summary>
    internal partial class SqlScriptsListResponse
    {
        /// <summary> Initializes a new instance of SqlScriptsListResponse. </summary>
        /// <param name="value"> List of sql scripts. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal SqlScriptsListResponse(IEnumerable<SqlScriptResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of SqlScriptsListResponse. </summary>
        /// <param name="value"> List of sql scripts. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal SqlScriptsListResponse(IReadOnlyList<SqlScriptResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of sql scripts. </summary>
        public IReadOnlyList<SqlScriptResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
