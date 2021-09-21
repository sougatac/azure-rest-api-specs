// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtifactsClient.Models
{
    /// <summary> A list activity runs. </summary>
    public partial class ActivityRunsQueryResponse
    {
        /// <summary> Initializes a new instance of ActivityRunsQueryResponse. </summary>
        /// <param name="value"> List of activity runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ActivityRunsQueryResponse(IEnumerable<ActivityRun> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ActivityRunsQueryResponse. </summary>
        /// <param name="value"> List of activity runs. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        internal ActivityRunsQueryResponse(IReadOnlyList<ActivityRun> value, string continuationToken)
        {
            Value = value;
            ContinuationToken = continuationToken;
        }

        /// <summary> List of activity runs. </summary>
        public IReadOnlyList<ActivityRun> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
