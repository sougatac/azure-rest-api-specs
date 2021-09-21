// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class TumblingWindowTriggerDependencyReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Offset))
            {
                writer.WritePropertyName("offset");
                writer.WriteStringValue(Offset);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("size");
                writer.WriteStringValue(Size);
            }
            writer.WritePropertyName("referenceTrigger");
            writer.WriteObjectValue(ReferenceTrigger);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            writer.WriteEndObject();
        }

        internal static TumblingWindowTriggerDependencyReference DeserializeTumblingWindowTriggerDependencyReference(JsonElement element)
        {
            Optional<string> offset = default;
            Optional<string> size = default;
            TriggerReference referenceTrigger = default;
            string type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceTrigger"))
                {
                    referenceTrigger = TriggerReference.DeserializeTriggerReference(property.Value);
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new TumblingWindowTriggerDependencyReference(type, referenceTrigger, offset.Value, size.Value);
        }
    }
}
