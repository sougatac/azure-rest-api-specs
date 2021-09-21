// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The level of compute power that each node in the Big Data pool has. </summary>
    public readonly partial struct NodeSize : IEquatable<NodeSize>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NodeSize"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NodeSize(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SmallValue = "Small";
        private const string MediumValue = "Medium";
        private const string LargeValue = "Large";
        private const string XLargeValue = "XLarge";
        private const string XXLargeValue = "XXLarge";
        private const string XXXLargeValue = "XXXLarge";

        /// <summary> None. </summary>
        public static NodeSize None { get; } = new NodeSize(NoneValue);
        /// <summary> Small. </summary>
        public static NodeSize Small { get; } = new NodeSize(SmallValue);
        /// <summary> Medium. </summary>
        public static NodeSize Medium { get; } = new NodeSize(MediumValue);
        /// <summary> Large. </summary>
        public static NodeSize Large { get; } = new NodeSize(LargeValue);
        /// <summary> XLarge. </summary>
        public static NodeSize XLarge { get; } = new NodeSize(XLargeValue);
        /// <summary> XXLarge. </summary>
        public static NodeSize XXLarge { get; } = new NodeSize(XXLargeValue);
        /// <summary> XXXLarge. </summary>
        public static NodeSize XXXLarge { get; } = new NodeSize(XXXLargeValue);
        /// <summary> Determines if two <see cref="NodeSize"/> values are the same. </summary>
        public static bool operator ==(NodeSize left, NodeSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NodeSize"/> values are not the same. </summary>
        public static bool operator !=(NodeSize left, NodeSize right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NodeSize"/>. </summary>
        public static implicit operator NodeSize(string value) => new NodeSize(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NodeSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NodeSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
