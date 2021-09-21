// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class SqlSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlReaderQuery))
            {
                writer.WritePropertyName("sqlReaderQuery");
                writer.WriteObjectValue(SqlReaderQuery);
            }
            if (Optional.IsDefined(SqlReaderStoredProcedureName))
            {
                writer.WritePropertyName("sqlReaderStoredProcedureName");
                writer.WriteObjectValue(SqlReaderStoredProcedureName);
            }
            if (Optional.IsCollectionDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters");
                writer.WriteStartObject();
                foreach (var item in StoredProcedureParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsolationLevel))
            {
                writer.WritePropertyName("isolationLevel");
                writer.WriteObjectValue(IsolationLevel);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption");
                writer.WriteObjectValue(PartitionOption);
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings");
                writer.WriteObjectValue(PartitionSettings);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout");
                writer.WriteObjectValue(QueryTimeout);
            }
            if (Optional.IsCollectionDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns");
                writer.WriteStartArray();
                foreach (var item in AdditionalColumns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount");
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait");
                writer.WriteObjectValue(SourceRetryWait);
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

        internal static SqlSource DeserializeSqlSource(JsonElement element)
        {
            Optional<object> sqlReaderQuery = default;
            Optional<object> sqlReaderStoredProcedureName = default;
            Optional<IDictionary<string, StoredProcedureParameter>> storedProcedureParameters = default;
            Optional<object> isolationLevel = default;
            Optional<object> partitionOption = default;
            Optional<SqlPartitionSettings> partitionSettings = default;
            Optional<object> queryTimeout = default;
            Optional<IList<AdditionalColumns>> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlReaderQuery"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlReaderQuery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sqlReaderStoredProcedureName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sqlReaderStoredProcedureName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, StoredProcedureParameter> dictionary = new Dictionary<string, StoredProcedureParameter>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, StoredProcedureParameter.DeserializeStoredProcedureParameter(property0.Value));
                    }
                    storedProcedureParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("isolationLevel"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isolationLevel = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionOption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionOption = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionSettings = SqlPartitionSettings.DeserializeSqlPartitionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("queryTimeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<AdditionalColumns> array = new List<AdditionalColumns>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AdditionalColumns.DeserializeAdditionalColumns(item));
                    }
                    additionalColumns = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
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
            return new SqlSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, queryTimeout.Value, Optional.ToList(additionalColumns), sqlReaderQuery.Value, sqlReaderStoredProcedureName.Value, Optional.ToDictionary(storedProcedureParameters), isolationLevel.Value, partitionOption.Value, partitionSettings.Value);
        }
    }
}
