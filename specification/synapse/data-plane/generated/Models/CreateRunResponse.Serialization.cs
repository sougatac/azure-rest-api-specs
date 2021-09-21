// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class CreateRunResponse
    {
        internal static CreateRunResponse DeserializeCreateRunResponse(JsonElement element)
        {
            string runId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"))
                {
                    runId = property.Value.GetString();
                    continue;
                }
            }
            return new CreateRunResponse(runId);
        }
    }
}
