// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Azure Function linked service. </summary>
    public partial class AzureFunctionLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureFunctionLinkedService. </summary>
        /// <param name="functionAppUrl"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppUrl"/> is null. </exception>
        public AzureFunctionLinkedService(object functionAppUrl)
        {
            if (functionAppUrl == null)
            {
                throw new ArgumentNullException(nameof(functionAppUrl));
            }

            FunctionAppUrl = functionAppUrl;
            Type = "AzureFunction";
        }

        /// <summary> Initializes a new instance of AzureFunctionLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="functionAppUrl"> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. </param>
        /// <param name="functionKey"> Function or Host key for Azure Function App. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureFunctionLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object functionAppUrl, SecretBase functionKey, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            FunctionAppUrl = functionAppUrl;
            FunctionKey = functionKey;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureFunction";
        }

        /// <summary> The endpoint of the Azure Function App. URL will be in the format https://&lt;accountName&gt;.azurewebsites.net. </summary>
        public object FunctionAppUrl { get; set; }
        /// <summary> Function or Host key for Azure Function App. </summary>
        public SecretBase FunctionKey { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
