// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class SqlScriptContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("query");
            writer.WriteStringValue(Query);
            writer.WritePropertyName("currentConnection");
            writer.WriteObjectValue(CurrentConnection);
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteObjectValue(Metadata);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlScriptContent DeserializeSqlScriptContent(JsonElement element)
        {
            string query = default;
            SqlConnection currentConnection = default;
            Optional<SqlScriptMetadata> metadata = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("query"))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentConnection"))
                {
                    currentConnection = SqlConnection.DeserializeSqlConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metadata = SqlScriptMetadata.DeserializeSqlScriptMetadata(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlScriptContent(query, currentConnection, metadata.Value, additionalProperties);
        }
    }
}
