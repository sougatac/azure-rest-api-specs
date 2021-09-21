// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ArtifactsClient.Models
{
    /// <summary> Details of the encryption associated with the workspace. </summary>
    public partial class EncryptionDetails
    {
        /// <summary> Initializes a new instance of EncryptionDetails. </summary>
        public EncryptionDetails()
        {
        }

        /// <summary> Initializes a new instance of EncryptionDetails. </summary>
        /// <param name="doubleEncryptionEnabled"> Double Encryption enabled. </param>
        /// <param name="cmk"> Customer Managed Key Details. </param>
        internal EncryptionDetails(bool? doubleEncryptionEnabled, CustomerManagedKeyDetails cmk)
        {
            DoubleEncryptionEnabled = doubleEncryptionEnabled;
            Cmk = cmk;
        }

        /// <summary> Double Encryption enabled. </summary>
        public bool? DoubleEncryptionEnabled { get; }
        /// <summary> Customer Managed Key Details. </summary>
        public CustomerManagedKeyDetails Cmk { get; set; }
    }
}
