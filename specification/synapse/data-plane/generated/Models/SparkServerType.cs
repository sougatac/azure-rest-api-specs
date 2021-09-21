// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The type of Spark server. </summary>
    public readonly partial struct SparkServerType : IEquatable<SparkServerType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkServerType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkServerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SharkServerValue = "SharkServer";
        private const string SharkServer2Value = "SharkServer2";
        private const string SparkThriftServerValue = "SparkThriftServer";

        /// <summary> SharkServer. </summary>
        public static SparkServerType SharkServer { get; } = new SparkServerType(SharkServerValue);
        /// <summary> SharkServer2. </summary>
        public static SparkServerType SharkServer2 { get; } = new SparkServerType(SharkServer2Value);
        /// <summary> SparkThriftServer. </summary>
        public static SparkServerType SparkThriftServer { get; } = new SparkServerType(SparkThriftServerValue);
        /// <summary> Determines if two <see cref="SparkServerType"/> values are the same. </summary>
        public static bool operator ==(SparkServerType left, SparkServerType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkServerType"/> values are not the same. </summary>
        public static bool operator !=(SparkServerType left, SparkServerType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkServerType"/>. </summary>
        public static implicit operator SparkServerType(string value) => new SparkServerType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkServerType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkServerType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
