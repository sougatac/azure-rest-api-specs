// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ArtifactsClient.Models
{
    /// <summary> The key authorization type integration runtime. </summary>
    public partial class LinkedIntegrationRuntimeKeyAuthorization : LinkedIntegrationRuntimeType
    {
        /// <summary> Initializes a new instance of LinkedIntegrationRuntimeKeyAuthorization. </summary>
        /// <param name="key"> The key used for authorization. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public LinkedIntegrationRuntimeKeyAuthorization(SecureString key)
        {
            if (key == null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            Key = key;
            AuthorizationType = "Key";
        }

        /// <summary> Initializes a new instance of LinkedIntegrationRuntimeKeyAuthorization. </summary>
        /// <param name="authorizationType"> The authorization type for integration runtime sharing. </param>
        /// <param name="key"> The key used for authorization. </param>
        internal LinkedIntegrationRuntimeKeyAuthorization(string authorizationType, SecureString key) : base(authorizationType)
        {
            Key = key;
            AuthorizationType = authorizationType ?? "Key";
        }

        /// <summary> The key used for authorization. </summary>
        public SecureString Key { get; set; }
    }
}
