// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class SynapseNotebookReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName");
            writer.WriteStringValue(ReferenceName);
            writer.WriteEndObject();
        }

        internal static SynapseNotebookReference DeserializeSynapseNotebookReference(JsonElement element)
        {
            NotebookReferenceType type = default;
            string referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new NotebookReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseNotebookReference(type, referenceName);
        }
    }
}
