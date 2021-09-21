// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class NotebookSessionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("driverMemory");
            writer.WriteStringValue(DriverMemory);
            writer.WritePropertyName("driverCores");
            writer.WriteNumberValue(DriverCores);
            writer.WritePropertyName("executorMemory");
            writer.WriteStringValue(ExecutorMemory);
            writer.WritePropertyName("executorCores");
            writer.WriteNumberValue(ExecutorCores);
            writer.WritePropertyName("numExecutors");
            writer.WriteNumberValue(NumExecutors);
            writer.WriteEndObject();
        }

        internal static NotebookSessionProperties DeserializeNotebookSessionProperties(JsonElement element)
        {
            string driverMemory = default;
            int driverCores = default;
            string executorMemory = default;
            int executorCores = default;
            int numExecutors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("driverMemory"))
                {
                    driverMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driverCores"))
                {
                    driverCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("executorMemory"))
                {
                    executorMemory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executorCores"))
                {
                    executorCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("numExecutors"))
                {
                    numExecutors = property.Value.GetInt32();
                    continue;
                }
            }
            return new NotebookSessionProperties(driverMemory, driverCores, executorMemory, executorCores, numExecutors);
        }
    }
}
