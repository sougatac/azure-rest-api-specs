// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class RunFilterParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken");
                writer.WriteStringValue(ContinuationToken);
            }
            writer.WritePropertyName("lastUpdatedAfter");
            writer.WriteStringValue(LastUpdatedAfter, "O");
            writer.WritePropertyName("lastUpdatedBefore");
            writer.WriteStringValue(LastUpdatedBefore, "O");
            if (Optional.IsCollectionDefined(Filters))
            {
                writer.WritePropertyName("filters");
                writer.WriteStartArray();
                foreach (var item in Filters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(OrderBy))
            {
                writer.WritePropertyName("orderBy");
                writer.WriteStartArray();
                foreach (var item in OrderBy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
