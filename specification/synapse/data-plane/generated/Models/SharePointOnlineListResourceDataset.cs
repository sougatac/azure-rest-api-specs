// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> The sharepoint online list resource dataset. </summary>
    public partial class SharePointOnlineListResourceDataset : Dataset
    {
        /// <summary> Initializes a new instance of SharePointOnlineListResourceDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public SharePointOnlineListResourceDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "SharePointOnlineListResource";
        }

        /// <summary> Initializes a new instance of SharePointOnlineListResourceDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="listName"> The name of the SharePoint Online list. Type: string (or Expression with resultType string). </param>
        internal SharePointOnlineListResourceDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object listName) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            ListName = listName;
            Type = type ?? "SharePointOnlineListResource";
        }

        /// <summary> The name of the SharePoint Online list. Type: string (or Expression with resultType string). </summary>
        public object ListName { get; set; }
    }
}
