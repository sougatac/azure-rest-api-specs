// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> The Azure Search Index. </summary>
    public partial class AzureSearchIndexDataset : Dataset
    {
        /// <summary> Initializes a new instance of AzureSearchIndexDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="indexName"> The name of the Azure Search Index. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="indexName"/> is null. </exception>
        public AzureSearchIndexDataset(LinkedServiceReference linkedServiceName, object indexName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }
            if (indexName == null)
            {
                throw new ArgumentNullException(nameof(indexName));
            }

            IndexName = indexName;
            Type = "AzureSearchIndex";
        }

        /// <summary> Initializes a new instance of AzureSearchIndexDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="indexName"> The name of the Azure Search Index. Type: string (or Expression with resultType string). </param>
        internal AzureSearchIndexDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object indexName) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            IndexName = indexName;
            Type = type ?? "AzureSearchIndex";
        }

        /// <summary> The name of the Azure Search Index. Type: string (or Expression with resultType string). </summary>
        public object IndexName { get; set; }
    }
}
