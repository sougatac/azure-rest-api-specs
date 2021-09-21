// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class SparkBatchJobState
    {
        internal static SparkBatchJobState DeserializeSparkBatchJobState(JsonElement element)
        {
            Optional<DateTimeOffset?> notStartedAt = default;
            Optional<DateTimeOffset?> startingAt = default;
            Optional<DateTimeOffset?> runningAt = default;
            Optional<DateTimeOffset?> deadAt = default;
            Optional<DateTimeOffset?> successAt = default;
            Optional<DateTimeOffset?> killedAt = default;
            Optional<DateTimeOffset?> recoveringAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notStartedAt = null;
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startingAt = null;
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runningAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runningAt = null;
                        continue;
                    }
                    runningAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadAt = null;
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("successAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        successAt = null;
                        continue;
                    }
                    successAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        killedAt = null;
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recoveringAt = null;
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkBatchJobState(Optional.ToNullable(notStartedAt), Optional.ToNullable(startingAt), Optional.ToNullable(runningAt), Optional.ToNullable(deadAt), Optional.ToNullable(successAt), Optional.ToNullable(killedAt), Optional.ToNullable(recoveringAt), currentState.Value, jobCreationRequest.Value);
        }
    }
}
