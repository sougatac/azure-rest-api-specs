// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class IntegrationRuntimeSsisProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CatalogInfo))
            {
                writer.WritePropertyName("catalogInfo");
                writer.WriteObjectValue(CatalogInfo);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (Optional.IsDefined(CustomSetupScriptProperties))
            {
                writer.WritePropertyName("customSetupScriptProperties");
                writer.WriteObjectValue(CustomSetupScriptProperties);
            }
            if (Optional.IsDefined(DataProxyProperties))
            {
                writer.WritePropertyName("dataProxyProperties");
                writer.WriteObjectValue(DataProxyProperties);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition");
                writer.WriteStringValue(Edition.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ExpressCustomSetupProperties))
            {
                writer.WritePropertyName("expressCustomSetupProperties");
                writer.WriteStartArray();
                foreach (var item in ExpressCustomSetupProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeSsisProperties DeserializeIntegrationRuntimeSsisProperties(JsonElement element)
        {
            Optional<IntegrationRuntimeSsisCatalogInfo> catalogInfo = default;
            Optional<IntegrationRuntimeLicenseType> licenseType = default;
            Optional<IntegrationRuntimeCustomSetupScriptProperties> customSetupScriptProperties = default;
            Optional<IntegrationRuntimeDataProxyProperties> dataProxyProperties = default;
            Optional<IntegrationRuntimeEdition> edition = default;
            Optional<IList<CustomSetupBase>> expressCustomSetupProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalogInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    catalogInfo = IntegrationRuntimeSsisCatalogInfo.DeserializeIntegrationRuntimeSsisCatalogInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    licenseType = new IntegrationRuntimeLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("customSetupScriptProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    customSetupScriptProperties = IntegrationRuntimeCustomSetupScriptProperties.DeserializeIntegrationRuntimeCustomSetupScriptProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("dataProxyProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataProxyProperties = IntegrationRuntimeDataProxyProperties.DeserializeIntegrationRuntimeDataProxyProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("edition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    edition = new IntegrationRuntimeEdition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expressCustomSetupProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CustomSetupBase> array = new List<CustomSetupBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomSetupBase.DeserializeCustomSetupBase(item));
                    }
                    expressCustomSetupProperties = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeSsisProperties(catalogInfo.Value, Optional.ToNullable(licenseType), customSetupScriptProperties.Value, dataProxyProperties.Value, Optional.ToNullable(edition), Optional.ToList(expressCustomSetupProperties), additionalProperties);
        }
    }
}
