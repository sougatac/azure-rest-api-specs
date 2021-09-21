// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class TriggerRunsQueryResponse
    {
        internal static TriggerRunsQueryResponse DeserializeTriggerRunsQueryResponse(JsonElement element)
        {
            IReadOnlyList<TriggerRun> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<TriggerRun> array = new List<TriggerRun>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerRun.DeserializeTriggerRun(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new TriggerRunsQueryResponse(value, continuationToken.Value);
        }
    }
}
