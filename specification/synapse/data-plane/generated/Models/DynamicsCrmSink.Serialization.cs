// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class DynamicsCrmSink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("writeBehavior");
            writer.WriteStringValue(WriteBehavior.ToString());
            if (Optional.IsDefined(IgnoreNullValues))
            {
                writer.WritePropertyName("ignoreNullValues");
                writer.WriteObjectValue(IgnoreNullValues);
            }
            if (Optional.IsDefined(AlternateKeyName))
            {
                writer.WritePropertyName("alternateKeyName");
                writer.WriteObjectValue(AlternateKeyName);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(WriteBatchSize))
            {
                writer.WritePropertyName("writeBatchSize");
                writer.WriteObjectValue(WriteBatchSize);
            }
            if (Optional.IsDefined(WriteBatchTimeout))
            {
                writer.WritePropertyName("writeBatchTimeout");
                writer.WriteObjectValue(WriteBatchTimeout);
            }
            if (Optional.IsDefined(SinkRetryCount))
            {
                writer.WritePropertyName("sinkRetryCount");
                writer.WriteObjectValue(SinkRetryCount);
            }
            if (Optional.IsDefined(SinkRetryWait))
            {
                writer.WritePropertyName("sinkRetryWait");
                writer.WriteObjectValue(SinkRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DynamicsCrmSink DeserializeDynamicsCrmSink(JsonElement element)
        {
            DynamicsSinkWriteBehavior writeBehavior = default;
            Optional<object> ignoreNullValues = default;
            Optional<object> alternateKeyName = default;
            string type = default;
            Optional<object> writeBatchSize = default;
            Optional<object> writeBatchTimeout = default;
            Optional<object> sinkRetryCount = default;
            Optional<object> sinkRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("writeBehavior"))
                {
                    writeBehavior = new DynamicsSinkWriteBehavior(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ignoreNullValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ignoreNullValues = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("alternateKeyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    alternateKeyName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchSize = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    writeBatchTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sinkRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DynamicsCrmSink(type, writeBatchSize.Value, writeBatchTimeout.Value, sinkRetryCount.Value, sinkRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, writeBehavior, ignoreNullValues.Value, alternateKeyName.Value);
        }
    }
}
