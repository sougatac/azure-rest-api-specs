// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> The location of ftp server dataset. </summary>
    public partial class FtpServerLocation : DatasetLocation
    {
        /// <summary> Initializes a new instance of FtpServerLocation. </summary>
        public FtpServerLocation()
        {
            Type = "FtpServerLocation";
        }

        /// <summary> Initializes a new instance of FtpServerLocation. </summary>
        /// <param name="type"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FtpServerLocation(string type, object folderPath, object fileName, IDictionary<string, object> additionalProperties) : base(type, folderPath, fileName, additionalProperties)
        {
            Type = type ?? "FtpServerLocation";
        }
    }
}
