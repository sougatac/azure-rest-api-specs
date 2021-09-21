// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ArtifactsClient.Models
{
    /// <summary> Response body with a run identifier. </summary>
    public partial class CreateRunResponse
    {
        /// <summary> Initializes a new instance of CreateRunResponse. </summary>
        /// <param name="runId"> Identifier of a run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="runId"/> is null. </exception>
        internal CreateRunResponse(string runId)
        {
            if (runId == null)
            {
                throw new ArgumentNullException(nameof(runId));
            }

            RunId = runId;
        }

        /// <summary> Identifier of a run. </summary>
        public string RunId { get; }
    }
}
