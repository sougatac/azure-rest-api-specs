// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class StoreReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StoreReadSettings DeserializeStoreReadSettings(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3ReadSettings": return AmazonS3ReadSettings.DeserializeAmazonS3ReadSettings(element);
                    case "AzureBlobFSReadSettings": return AzureBlobFSReadSettings.DeserializeAzureBlobFSReadSettings(element);
                    case "AzureBlobStorageReadSettings": return AzureBlobStorageReadSettings.DeserializeAzureBlobStorageReadSettings(element);
                    case "AzureDataLakeStoreReadSettings": return AzureDataLakeStoreReadSettings.DeserializeAzureDataLakeStoreReadSettings(element);
                    case "AzureFileStorageReadSettings": return AzureFileStorageReadSettings.DeserializeAzureFileStorageReadSettings(element);
                    case "FileServerReadSettings": return FileServerReadSettings.DeserializeFileServerReadSettings(element);
                    case "FtpReadSettings": return FtpReadSettings.DeserializeFtpReadSettings(element);
                    case "GoogleCloudStorageReadSettings": return GoogleCloudStorageReadSettings.DeserializeGoogleCloudStorageReadSettings(element);
                    case "HdfsReadSettings": return HdfsReadSettings.DeserializeHdfsReadSettings(element);
                    case "HttpReadSettings": return HttpReadSettings.DeserializeHttpReadSettings(element);
                    case "SftpReadSettings": return SftpReadSettings.DeserializeSftpReadSettings(element);
                }
            }
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new StoreReadSettings(type, maxConcurrentConnections.Value, additionalProperties);
        }
    }
}
