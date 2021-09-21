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
    public partial class SqlPool : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes");
                writer.WriteNumberValue(MaxSizeBytes.Value);
            }
            if (Optional.IsDefined(Collation))
            {
                writer.WritePropertyName("collation");
                writer.WriteStringValue(Collation);
            }
            if (Optional.IsDefined(SourceDatabaseId))
            {
                writer.WritePropertyName("sourceDatabaseId");
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (Optional.IsDefined(RecoverableDatabaseId))
            {
                writer.WritePropertyName("recoverableDatabaseId");
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(RestorePointInTime))
            {
                writer.WritePropertyName("restorePointInTime");
                writer.WriteStringValue(RestorePointInTime);
            }
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode");
                writer.WriteStringValue(CreateMode);
            }
            if (Optional.IsDefined(CreationDate))
            {
                writer.WritePropertyName("creationDate");
                writer.WriteStringValue(CreationDate.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SqlPool DeserializeSqlPool(JsonElement element)
        {
            Optional<Sku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            string location = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<long> maxSizeBytes = default;
            Optional<string> collation = default;
            Optional<string> sourceDatabaseId = default;
            Optional<string> recoverableDatabaseId = default;
            Optional<string> provisioningState = default;
            Optional<string> status = default;
            Optional<string> restorePointInTime = default;
            Optional<string> createMode = default;
            Optional<DateTimeOffset> creationDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sku = Sku.DeserializeSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("maxSizeBytes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            maxSizeBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("collation"))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"))
                        {
                            sourceDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"))
                        {
                            recoverableDatabaseId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"))
                        {
                            restorePointInTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createMode"))
                        {
                            createMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SqlPool(id.Value, name.Value, type.Value, Optional.ToDictionary(tags), location, sku.Value, Optional.ToNullable(maxSizeBytes), collation.Value, sourceDatabaseId.Value, recoverableDatabaseId.Value, provisioningState.Value, status.Value, restorePointInTime.Value, createMode.Value, Optional.ToNullable(creationDate));
        }
    }
}
