// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class DataFlowDebugCommandResponse
    {
        internal static DataFlowDebugCommandResponse DeserializeDataFlowDebugCommandResponse(JsonElement element)
        {
            Optional<string> status = default;
            Optional<string> data = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    data = property.Value.GetString();
                    continue;
                }
            }
            return new DataFlowDebugCommandResponse(status.Value, data.Value);
        }
    }
}
