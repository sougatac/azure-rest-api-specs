// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The write behavior for the operation. Default is Insert. </summary>
    public readonly partial struct SalesforceSinkWriteBehavior : IEquatable<SalesforceSinkWriteBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SalesforceSinkWriteBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SalesforceSinkWriteBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InsertValue = "Insert";
        private const string UpsertValue = "Upsert";

        /// <summary> Insert. </summary>
        public static SalesforceSinkWriteBehavior Insert { get; } = new SalesforceSinkWriteBehavior(InsertValue);
        /// <summary> Upsert. </summary>
        public static SalesforceSinkWriteBehavior Upsert { get; } = new SalesforceSinkWriteBehavior(UpsertValue);
        /// <summary> Determines if two <see cref="SalesforceSinkWriteBehavior"/> values are the same. </summary>
        public static bool operator ==(SalesforceSinkWriteBehavior left, SalesforceSinkWriteBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SalesforceSinkWriteBehavior"/> values are not the same. </summary>
        public static bool operator !=(SalesforceSinkWriteBehavior left, SalesforceSinkWriteBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SalesforceSinkWriteBehavior"/>. </summary>
        public static implicit operator SalesforceSinkWriteBehavior(string value) => new SalesforceSinkWriteBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SalesforceSinkWriteBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SalesforceSinkWriteBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
