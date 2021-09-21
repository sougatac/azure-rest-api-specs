// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Linked service for Amazon S3. </summary>
    public partial class AmazonS3LinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AmazonS3LinkedService. </summary>
        public AmazonS3LinkedService()
        {
            Type = "AmazonS3";
        }

        /// <summary> Initializes a new instance of AmazonS3LinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="authenticationType"> The authentication type of S3. Allowed value: AccessKey (default) or TemporarySecurityCredentials. Type: string (or Expression with resultType string). </param>
        /// <param name="accessKeyId"> The access key identifier of the Amazon S3 Identity and Access Management (IAM) user. Type: string (or Expression with resultType string). </param>
        /// <param name="secretAccessKey"> The secret access key of the Amazon S3 Identity and Access Management (IAM) user. </param>
        /// <param name="serviceUrl"> This value specifies the endpoint to access with the S3 Connector. This is an optional property; change it only if you want to try a different service endpoint or want to switch between https and http. Type: string (or Expression with resultType string). </param>
        /// <param name="sessionToken"> The session token for the S3 temporary security credential. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AmazonS3LinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object authenticationType, object accessKeyId, SecretBase secretAccessKey, object serviceUrl, SecretBase sessionToken, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            AuthenticationType = authenticationType;
            AccessKeyId = accessKeyId;
            SecretAccessKey = secretAccessKey;
            ServiceUrl = serviceUrl;
            SessionToken = sessionToken;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AmazonS3";
        }

        /// <summary> The authentication type of S3. Allowed value: AccessKey (default) or TemporarySecurityCredentials. Type: string (or Expression with resultType string). </summary>
        public object AuthenticationType { get; set; }
        /// <summary> The access key identifier of the Amazon S3 Identity and Access Management (IAM) user. Type: string (or Expression with resultType string). </summary>
        public object AccessKeyId { get; set; }
        /// <summary> The secret access key of the Amazon S3 Identity and Access Management (IAM) user. </summary>
        public SecretBase SecretAccessKey { get; set; }
        /// <summary> This value specifies the endpoint to access with the S3 Connector. This is an optional property; change it only if you want to try a different service endpoint or want to switch between https and http. Type: string (or Expression with resultType string). </summary>
        public object ServiceUrl { get; set; }
        /// <summary> The session token for the S3 temporary security credential. </summary>
        public SecretBase SessionToken { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
