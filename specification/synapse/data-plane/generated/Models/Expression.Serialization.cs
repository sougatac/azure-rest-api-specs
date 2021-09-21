// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class Expression : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("value");
            writer.WriteStringValue(Value);
            writer.WriteEndObject();
        }

        internal static Expression DeserializeExpression(JsonElement element)
        {
            ExpressionType type = default;
            string value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new ExpressionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
            }
            return new Expression(type, value);
        }
    }
}
