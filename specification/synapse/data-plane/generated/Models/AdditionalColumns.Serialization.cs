// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class AdditionalColumns : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteObjectValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteObjectValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static AdditionalColumns DeserializeAdditionalColumns(JsonElement element)
        {
            Optional<object> name = default;
            Optional<object> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    name = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new AdditionalColumns(name.Value, value.Value);
        }
    }
}
