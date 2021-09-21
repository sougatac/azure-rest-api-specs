// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> The snowflake dataset. </summary>
    public partial class SnowflakeDataset : Dataset
    {
        /// <summary> Initializes a new instance of SnowflakeDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> is null. </exception>
        public SnowflakeDataset(LinkedServiceReference linkedServiceName) : base(linkedServiceName)
        {
            if (linkedServiceName == null)
            {
                throw new ArgumentNullException(nameof(linkedServiceName));
            }

            Type = "SnowflakeTable";
        }

        /// <summary> Initializes a new instance of SnowflakeDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="schemaTypePropertiesSchema"> The schema name of the Snowflake database. Type: string (or Expression with resultType string). </param>
        /// <param name="table"> The table name of the Snowflake database. Type: string (or Expression with resultType string). </param>
        internal SnowflakeDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object schemaTypePropertiesSchema, object table) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            SchemaTypePropertiesSchema = schemaTypePropertiesSchema;
            Table = table;
            Type = type ?? "SnowflakeTable";
        }

        /// <summary> The schema name of the Snowflake database. Type: string (or Expression with resultType string). </summary>
        public object SchemaTypePropertiesSchema { get; set; }
        /// <summary> The table name of the Snowflake database. Type: string (or Expression with resultType string). </summary>
        public object Table { get; set; }
    }
}
