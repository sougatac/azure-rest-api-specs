// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class ManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static ManagedIdentity DeserializeManagedIdentity(JsonElement element)
        {
            Optional<string> principalId = default;
            Optional<Guid> tenantId = default;
            Optional<ResourceIdentityType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"))
                {
                    principalId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToResourceIdentityType();
                    continue;
                }
            }
            return new ManagedIdentity(principalId.Value, Optional.ToNullable(tenantId), Optional.ToNullable(type));
        }
    }
}
