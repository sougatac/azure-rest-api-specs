// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class DatasetLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath");
                writer.WriteObjectValue(FolderPath);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName");
                writer.WriteObjectValue(FileName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DatasetLocation DeserializeDatasetLocation(JsonElement element)
        {
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AmazonS3Location": return AmazonS3Location.DeserializeAmazonS3Location(element);
                    case "AzureBlobFSLocation": return AzureBlobFSLocation.DeserializeAzureBlobFSLocation(element);
                    case "AzureBlobStorageLocation": return AzureBlobStorageLocation.DeserializeAzureBlobStorageLocation(element);
                    case "AzureDataLakeStoreLocation": return AzureDataLakeStoreLocation.DeserializeAzureDataLakeStoreLocation(element);
                    case "AzureFileStorageLocation": return AzureFileStorageLocation.DeserializeAzureFileStorageLocation(element);
                    case "FileServerLocation": return FileServerLocation.DeserializeFileServerLocation(element);
                    case "FtpServerLocation": return FtpServerLocation.DeserializeFtpServerLocation(element);
                    case "GoogleCloudStorageLocation": return GoogleCloudStorageLocation.DeserializeGoogleCloudStorageLocation(element);
                    case "HdfsLocation": return HdfsLocation.DeserializeHdfsLocation(element);
                    case "HttpServerLocation": return HttpServerLocation.DeserializeHttpServerLocation(element);
                    case "SftpLocation": return SftpLocation.DeserializeSftpLocation(element);
                }
            }
            string type = default;
            Optional<object> folderPath = default;
            Optional<object> fileName = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    folderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fileName = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetLocation(type, folderPath.Value, fileName.Value, additionalProperties);
        }
    }
}
