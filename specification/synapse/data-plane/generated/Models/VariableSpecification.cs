// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ArtifactsClient.Models
{
    /// <summary> Definition of a single variable for a Pipeline. </summary>
    public partial class VariableSpecification
    {
        /// <summary> Initializes a new instance of VariableSpecification. </summary>
        /// <param name="type"> Variable type. </param>
        public VariableSpecification(VariableType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of VariableSpecification. </summary>
        /// <param name="type"> Variable type. </param>
        /// <param name="defaultValue"> Default value of variable. </param>
        internal VariableSpecification(VariableType type, object defaultValue)
        {
            Type = type;
            DefaultValue = defaultValue;
        }

        /// <summary> Variable type. </summary>
        public VariableType Type { get; set; }
        /// <summary> Default value of variable. </summary>
        public object DefaultValue { get; set; }
    }
}
