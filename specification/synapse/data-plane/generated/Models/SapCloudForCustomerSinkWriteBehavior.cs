// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The write behavior for the operation. Default is &apos;Insert&apos;. </summary>
    public readonly partial struct SapCloudForCustomerSinkWriteBehavior : IEquatable<SapCloudForCustomerSinkWriteBehavior>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapCloudForCustomerSinkWriteBehavior"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapCloudForCustomerSinkWriteBehavior(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InsertValue = "Insert";
        private const string UpdateValue = "Update";

        /// <summary> Insert. </summary>
        public static SapCloudForCustomerSinkWriteBehavior Insert { get; } = new SapCloudForCustomerSinkWriteBehavior(InsertValue);
        /// <summary> Update. </summary>
        public static SapCloudForCustomerSinkWriteBehavior Update { get; } = new SapCloudForCustomerSinkWriteBehavior(UpdateValue);
        /// <summary> Determines if two <see cref="SapCloudForCustomerSinkWriteBehavior"/> values are the same. </summary>
        public static bool operator ==(SapCloudForCustomerSinkWriteBehavior left, SapCloudForCustomerSinkWriteBehavior right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapCloudForCustomerSinkWriteBehavior"/> values are not the same. </summary>
        public static bool operator !=(SapCloudForCustomerSinkWriteBehavior left, SapCloudForCustomerSinkWriteBehavior right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapCloudForCustomerSinkWriteBehavior"/>. </summary>
        public static implicit operator SapCloudForCustomerSinkWriteBehavior(string value) => new SapCloudForCustomerSinkWriteBehavior(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapCloudForCustomerSinkWriteBehavior other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapCloudForCustomerSinkWriteBehavior other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
