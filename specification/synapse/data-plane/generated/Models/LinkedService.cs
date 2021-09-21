// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> The Azure Synapse nested object which contains the information and credential which can be used to connect with related store or compute resource. </summary>
    public partial class LinkedService
    {
        /// <summary> Initializes a new instance of LinkedService. </summary>
        public LinkedService()
        {
            Parameters = new ChangeTrackingDictionary<string, ParameterSpecification>();
            Annotations = new ChangeTrackingList<object>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
            Type = "LinkedService";
        }

        /// <summary> Initializes a new instance of LinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal LinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties)
        {
            Type = type ?? "LinkedService";
            ConnectVia = connectVia;
            Description = description;
            Parameters = parameters;
            Annotations = annotations;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of linked service. </summary>
        internal string Type { get; set; }
        /// <summary> The integration runtime reference. </summary>
        public IntegrationRuntimeReference ConnectVia { get; set; }
        /// <summary> Linked service description. </summary>
        public string Description { get; set; }
        /// <summary> Parameters for linked service. </summary>
        public IDictionary<string, ParameterSpecification> Parameters { get; }
        /// <summary> List of tags that can be used for describing the linked service. </summary>
        public IList<object> Annotations { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
