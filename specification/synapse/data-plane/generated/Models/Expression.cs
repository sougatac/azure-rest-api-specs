// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace ArtifactsClient.Models
{
    /// <summary> Azure Synapse expression definition. </summary>
    public partial class Expression
    {
        /// <summary> Initializes a new instance of Expression. </summary>
        /// <param name="type"> Expression type. </param>
        /// <param name="value"> Expression value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Expression(ExpressionType type, string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Type = type;
            Value = value;
        }

        /// <summary> Expression type. </summary>
        public ExpressionType Type { get; set; }
        /// <summary> Expression value. </summary>
        public string Value { get; set; }
    }
}
