// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class PipelineRun
    {
        internal static PipelineRun DeserializePipelineRun(JsonElement element)
        {
            Optional<string> runId = default;
            Optional<string> runGroupId = default;
            Optional<bool> isLatest = default;
            Optional<string> pipelineName = default;
            Optional<IReadOnlyDictionary<string, string>> parameters = default;
            Optional<PipelineRunInvokedBy> invokedBy = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<DateTimeOffset> runStart = default;
            Optional<DateTimeOffset?> runEnd = default;
            Optional<int> durationInMs = default;
            Optional<string> status = default;
            Optional<string> message = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runGroupId"))
                {
                    runGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isLatest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pipelineName"))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("invokedBy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    invokedBy = PipelineRunInvokedBy.DeserializePipelineRunInvokedBy(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runStart"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    runStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runEnd"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runEnd = null;
                        continue;
                    }
                    runEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new PipelineRun(runId.Value, runGroupId.Value, Optional.ToNullable(isLatest), pipelineName.Value, Optional.ToDictionary(parameters), invokedBy.Value, Optional.ToNullable(lastUpdated), Optional.ToNullable(runStart), Optional.ToNullable(runEnd), Optional.ToNullable(durationInMs), status.Value, message.Value, additionalProperties);
        }
    }
}
