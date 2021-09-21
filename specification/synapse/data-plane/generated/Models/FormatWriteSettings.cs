// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> Format write settings. </summary>
    public partial class FormatWriteSettings
    {
        /// <summary> Initializes a new instance of FormatWriteSettings. </summary>
        public FormatWriteSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "FormatWriteSettings";
        }

        /// <summary> Initializes a new instance of FormatWriteSettings. </summary>
        /// <param name="type"> The write setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FormatWriteSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type ?? "FormatWriteSettings";
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The write setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
