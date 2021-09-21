// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Presto server linked service. </summary>
    public partial class PrestoLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of PrestoLinkedService. </summary>
        /// <param name="host"> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </param>
        /// <param name="serverVersion"> The version of the Presto server. (i.e. 0.148-t). </param>
        /// <param name="catalog"> The catalog context for all request against the server. </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Presto server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/>, <paramref name="serverVersion"/>, or <paramref name="catalog"/> is null. </exception>
        public PrestoLinkedService(object host, object serverVersion, object catalog, PrestoAuthenticationType authenticationType)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (serverVersion == null)
            {
                throw new ArgumentNullException(nameof(serverVersion));
            }
            if (catalog == null)
            {
                throw new ArgumentNullException(nameof(catalog));
            }

            Host = host;
            ServerVersion = serverVersion;
            Catalog = catalog;
            AuthenticationType = authenticationType;
            Type = "Presto";
        }

        /// <summary> Initializes a new instance of PrestoLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </param>
        /// <param name="serverVersion"> The version of the Presto server. (i.e. 0.148-t). </param>
        /// <param name="catalog"> The catalog context for all request against the server. </param>
        /// <param name="port"> The TCP port that the Presto server uses to listen for client connections. The default value is 8080. </param>
        /// <param name="authenticationType"> The authentication mechanism used to connect to the Presto server. </param>
        /// <param name="username"> The user name used to connect to the Presto server. </param>
        /// <param name="password"> The password corresponding to the user name. </param>
        /// <param name="enableSsl"> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </param>
        /// <param name="trustedCertPath"> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </param>
        /// <param name="useSystemTrustStore"> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </param>
        /// <param name="allowHostNameCNMismatch"> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </param>
        /// <param name="allowSelfSignedServerCert"> Specifies whether to allow self-signed certificates from the server. The default value is false. </param>
        /// <param name="timeZoneID"> The local time zone used by the connection. Valid values for this option are specified in the IANA Time Zone Database. The default value is the system time zone. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal PrestoLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object serverVersion, object catalog, object port, PrestoAuthenticationType authenticationType, object username, SecretBase password, object enableSsl, object trustedCertPath, object useSystemTrustStore, object allowHostNameCNMismatch, object allowSelfSignedServerCert, object timeZoneID, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            ServerVersion = serverVersion;
            Catalog = catalog;
            Port = port;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EnableSsl = enableSsl;
            TrustedCertPath = trustedCertPath;
            UseSystemTrustStore = useSystemTrustStore;
            AllowHostNameCNMismatch = allowHostNameCNMismatch;
            AllowSelfSignedServerCert = allowSelfSignedServerCert;
            TimeZoneID = timeZoneID;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Presto";
        }

        /// <summary> The IP address or host name of the Presto server. (i.e. 192.168.222.160). </summary>
        public object Host { get; set; }
        /// <summary> The version of the Presto server. (i.e. 0.148-t). </summary>
        public object ServerVersion { get; set; }
        /// <summary> The catalog context for all request against the server. </summary>
        public object Catalog { get; set; }
        /// <summary> The TCP port that the Presto server uses to listen for client connections. The default value is 8080. </summary>
        public object Port { get; set; }
        /// <summary> The authentication mechanism used to connect to the Presto server. </summary>
        public PrestoAuthenticationType AuthenticationType { get; set; }
        /// <summary> The user name used to connect to the Presto server. </summary>
        public object Username { get; set; }
        /// <summary> The password corresponding to the user name. </summary>
        public SecretBase Password { get; set; }
        /// <summary> Specifies whether the connections to the server are encrypted using SSL. The default value is false. </summary>
        public object EnableSsl { get; set; }
        /// <summary> The full path of the .pem file containing trusted CA certificates for verifying the server when connecting over SSL. This property can only be set when using SSL on self-hosted IR. The default value is the cacerts.pem file installed with the IR. </summary>
        public object TrustedCertPath { get; set; }
        /// <summary> Specifies whether to use a CA certificate from the system trust store or from a specified PEM file. The default value is false. </summary>
        public object UseSystemTrustStore { get; set; }
        /// <summary> Specifies whether to require a CA-issued SSL certificate name to match the host name of the server when connecting over SSL. The default value is false. </summary>
        public object AllowHostNameCNMismatch { get; set; }
        /// <summary> Specifies whether to allow self-signed certificates from the server. The default value is false. </summary>
        public object AllowSelfSignedServerCert { get; set; }
        /// <summary> The local time zone used by the connection. Valid values for this option are specified in the IANA Time Zone Database. The default value is the system time zone. </summary>
        public object TimeZoneID { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
