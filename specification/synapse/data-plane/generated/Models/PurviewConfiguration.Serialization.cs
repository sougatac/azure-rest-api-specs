// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class PurviewConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PurviewResourceId))
            {
                writer.WritePropertyName("purviewResourceId");
                writer.WriteStringValue(PurviewResourceId);
            }
            writer.WriteEndObject();
        }

        internal static PurviewConfiguration DeserializePurviewConfiguration(JsonElement element)
        {
            Optional<string> purviewResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purviewResourceId"))
                {
                    purviewResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new PurviewConfiguration(purviewResourceId.Value);
        }
    }
}
