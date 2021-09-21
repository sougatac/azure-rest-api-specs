// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace ArtifactsClient.Models
{
    public partial class WorkspaceRepositoryConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Optional.IsDefined(HostName))
            {
                writer.WritePropertyName("hostName");
                writer.WriteStringValue(HostName);
            }
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName");
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ProjectName))
            {
                writer.WritePropertyName("projectName");
                writer.WriteStringValue(ProjectName);
            }
            if (Optional.IsDefined(RepositoryName))
            {
                writer.WritePropertyName("repositoryName");
                writer.WriteStringValue(RepositoryName);
            }
            if (Optional.IsDefined(CollaborationBranch))
            {
                writer.WritePropertyName("collaborationBranch");
                writer.WriteStringValue(CollaborationBranch);
            }
            if (Optional.IsDefined(RootFolder))
            {
                writer.WritePropertyName("rootFolder");
                writer.WriteStringValue(RootFolder);
            }
            if (Optional.IsDefined(LastCommitId))
            {
                writer.WritePropertyName("lastCommitId");
                writer.WriteStringValue(LastCommitId);
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId");
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(ClientId))
            {
                writer.WritePropertyName("clientId");
                writer.WriteStringValue(ClientId);
            }
            if (Optional.IsDefined(ClientSecret))
            {
                writer.WritePropertyName("clientSecret");
                writer.WriteObjectValue(ClientSecret);
            }
            writer.WriteEndObject();
        }

        internal static WorkspaceRepositoryConfiguration DeserializeWorkspaceRepositoryConfiguration(JsonElement element)
        {
            Optional<string> type = default;
            Optional<string> hostName = default;
            Optional<string> accountName = default;
            Optional<string> projectName = default;
            Optional<string> repositoryName = default;
            Optional<string> collaborationBranch = default;
            Optional<string> rootFolder = default;
            Optional<string> lastCommitId = default;
            Optional<Guid> tenantId = default;
            Optional<string> clientId = default;
            Optional<GitHubClientSecret> clientSecret = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostName"))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountName"))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectName"))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("collaborationBranch"))
                {
                    collaborationBranch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rootFolder"))
                {
                    rootFolder = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastCommitId"))
                {
                    lastCommitId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientId"))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    clientSecret = GitHubClientSecret.DeserializeGitHubClientSecret(property.Value);
                    continue;
                }
            }
            return new WorkspaceRepositoryConfiguration(type.Value, hostName.Value, accountName.Value, projectName.Value, repositoryName.Value, collaborationBranch.Value, rootFolder.Value, lastCommitId.Value, Optional.ToNullable(tenantId), clientId.Value, clientSecret.Value);
        }
    }
}
