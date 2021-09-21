// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    internal partial class PipelineListResponse
    {
        internal static PipelineListResponse DeserializePipelineListResponse(JsonElement element)
        {
            IReadOnlyList<PipelineResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<PipelineResource> array = new List<PipelineResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PipelineResource.DeserializePipelineResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PipelineListResponse(value, nextLink.Value);
        }
    }
}
