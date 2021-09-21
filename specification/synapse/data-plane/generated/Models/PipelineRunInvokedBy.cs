// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ArtifactsClient.Models
{
    /// <summary> Provides entity name and id that started the pipeline run. </summary>
    public partial class PipelineRunInvokedBy
    {
        /// <summary> Initializes a new instance of PipelineRunInvokedBy. </summary>
        internal PipelineRunInvokedBy()
        {
        }

        /// <summary> Initializes a new instance of PipelineRunInvokedBy. </summary>
        /// <param name="name"> Name of the entity that started the pipeline run. </param>
        /// <param name="id"> The ID of the entity that started the run. </param>
        /// <param name="invokedByType"> The type of the entity that started the run. </param>
        internal PipelineRunInvokedBy(string name, string id, string invokedByType)
        {
            Name = name;
            Id = id;
            InvokedByType = invokedByType;
        }

        /// <summary> Name of the entity that started the pipeline run. </summary>
        public string Name { get; }
        /// <summary> The ID of the entity that started the run. </summary>
        public string Id { get; }
        /// <summary> The type of the entity that started the run. </summary>
        public string InvokedByType { get; }
    }
}
