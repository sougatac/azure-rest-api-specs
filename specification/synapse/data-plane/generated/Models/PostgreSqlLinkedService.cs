// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Linked service for PostgreSQL data source. </summary>
    public partial class PostgreSqlLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of PostgreSqlLinkedService. </summary>
        /// <param name="connectionString"> The connection string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="connectionString"/> is null. </exception>
        public PostgreSqlLinkedService(object connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }

            ConnectionString = connectionString;
            Type = "PostgreSql";
        }

        /// <summary> Initializes a new instance of PostgreSqlLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal PostgreSqlLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, AzureKeyVaultSecretReference password, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "PostgreSql";
        }

        /// <summary> The connection string. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. </summary>
        public AzureKeyVaultSecretReference Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
