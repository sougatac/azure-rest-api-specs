// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Sftp write settings. </summary>
    public partial class SftpWriteSettings : StoreWriteSettings
    {
        /// <summary> Initializes a new instance of SftpWriteSettings. </summary>
        public SftpWriteSettings()
        {
            Type = "SftpWriteSettings";
        }

        /// <summary> Initializes a new instance of SftpWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="copyBehavior"> The type of copy behavior for copy sink. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="operationTimeout"> Specifies the timeout for writing each chunk to SFTP server. Default value: 01:00:00 (one hour). Type: string (or Expression with resultType string). </param>
        /// <param name="useTempFileRename"> Upload to temporary file(s) and rename. Disable this option if your SFTP server doesn&apos;t support rename operation. Type: boolean (or Expression with resultType boolean). </param>
        internal SftpWriteSettings(string type, object maxConcurrentConnections, object copyBehavior, IDictionary<string, object> additionalProperties, object operationTimeout, object useTempFileRename) : base(type, maxConcurrentConnections, copyBehavior, additionalProperties)
        {
            OperationTimeout = operationTimeout;
            UseTempFileRename = useTempFileRename;
            Type = type ?? "SftpWriteSettings";
        }

        /// <summary> Specifies the timeout for writing each chunk to SFTP server. Default value: 01:00:00 (one hour). Type: string (or Expression with resultType string). </summary>
        public object OperationTimeout { get; set; }
        /// <summary> Upload to temporary file(s) and rename. Disable this option if your SFTP server doesn&apos;t support rename operation. Type: boolean (or Expression with resultType boolean). </summary>
        public object UseTempFileRename { get; set; }
    }
}
