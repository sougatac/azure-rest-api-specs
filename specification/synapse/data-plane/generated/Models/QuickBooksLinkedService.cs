// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> QuickBooks server linked service. </summary>
    public partial class QuickBooksLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of QuickBooksLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com). </param>
        /// <param name="companyId"> The company ID of the QuickBooks company to authorize. </param>
        /// <param name="consumerKey"> The consumer key for OAuth 1.0 authentication. </param>
        /// <param name="consumerSecret"> The consumer secret for OAuth 1.0 authentication. </param>
        /// <param name="accessToken"> The access token for OAuth 1.0 authentication. </param>
        /// <param name="accessTokenSecret"> The access token secret for OAuth 1.0 authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/>, <paramref name="companyId"/>, <paramref name="consumerKey"/>, <paramref name="consumerSecret"/>, <paramref name="accessToken"/>, or <paramref name="accessTokenSecret"/> is null. </exception>
        public QuickBooksLinkedService(object endpoint, object companyId, object consumerKey, SecretBase consumerSecret, SecretBase accessToken, SecretBase accessTokenSecret)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (companyId == null)
            {
                throw new ArgumentNullException(nameof(companyId));
            }
            if (consumerKey == null)
            {
                throw new ArgumentNullException(nameof(consumerKey));
            }
            if (consumerSecret == null)
            {
                throw new ArgumentNullException(nameof(consumerSecret));
            }
            if (accessToken == null)
            {
                throw new ArgumentNullException(nameof(accessToken));
            }
            if (accessTokenSecret == null)
            {
                throw new ArgumentNullException(nameof(accessTokenSecret));
            }

            Endpoint = endpoint;
            CompanyId = companyId;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
            Type = "QuickBooks";
        }

        /// <summary> Initializes a new instance of QuickBooksLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionProperties"> Properties used to connect to QuickBooks. It is mutually exclusive with any other properties in the linked service. Type: object. </param>
        /// <param name="endpoint"> The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com). </param>
        /// <param name="companyId"> The company ID of the QuickBooks company to authorize. </param>
        /// <param name="consumerKey"> The consumer key for OAuth 1.0 authentication. </param>
        /// <param name="consumerSecret"> The consumer secret for OAuth 1.0 authentication. </param>
        /// <param name="accessToken"> The access token for OAuth 1.0 authentication. </param>
        /// <param name="accessTokenSecret"> The access token secret for OAuth 1.0 authentication. </param>
        /// <param name="useEncryptedEndpoints"> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal QuickBooksLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionProperties, object endpoint, object companyId, object consumerKey, SecretBase consumerSecret, SecretBase accessToken, SecretBase accessTokenSecret, object useEncryptedEndpoints, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionProperties = connectionProperties;
            Endpoint = endpoint;
            CompanyId = companyId;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "QuickBooks";
        }

        /// <summary> Properties used to connect to QuickBooks. It is mutually exclusive with any other properties in the linked service. Type: object. </summary>
        public object ConnectionProperties { get; set; }
        /// <summary> The endpoint of the QuickBooks server. (i.e. quickbooks.api.intuit.com). </summary>
        public object Endpoint { get; set; }
        /// <summary> The company ID of the QuickBooks company to authorize. </summary>
        public object CompanyId { get; set; }
        /// <summary> The consumer key for OAuth 1.0 authentication. </summary>
        public object ConsumerKey { get; set; }
        /// <summary> The consumer secret for OAuth 1.0 authentication. </summary>
        public SecretBase ConsumerSecret { get; set; }
        /// <summary> The access token for OAuth 1.0 authentication. </summary>
        public SecretBase AccessToken { get; set; }
        /// <summary> The access token secret for OAuth 1.0 authentication. </summary>
        public SecretBase AccessTokenSecret { get; set; }
        /// <summary> Specifies whether the data source endpoints are encrypted using HTTPS. The default value is true. </summary>
        public object UseEncryptedEndpoints { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
