// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The consistency level specifies how many Cassandra servers must respond to a read request before returning data to the client application. Cassandra checks the specified number of Cassandra servers for data to satisfy the read request. Must be one of cassandraSourceReadConsistencyLevels. The default value is &apos;ONE&apos;. It is case-insensitive. </summary>
    public readonly partial struct CassandraSourceReadConsistencyLevels : IEquatable<CassandraSourceReadConsistencyLevels>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CassandraSourceReadConsistencyLevels"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CassandraSourceReadConsistencyLevels(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ALLValue = "ALL";
        private const string EachQuorumValue = "EACH_QUORUM";
        private const string QuorumValue = "QUORUM";
        private const string LocalQuorumValue = "LOCAL_QUORUM";
        private const string ONEValue = "ONE";
        private const string TWOValue = "TWO";
        private const string ThreeValue = "THREE";
        private const string LocalONEValue = "LOCAL_ONE";
        private const string SerialValue = "SERIAL";
        private const string LocalSerialValue = "LOCAL_SERIAL";

        /// <summary> ALL. </summary>
        public static CassandraSourceReadConsistencyLevels ALL { get; } = new CassandraSourceReadConsistencyLevels(ALLValue);
        /// <summary> EACH_QUORUM. </summary>
        public static CassandraSourceReadConsistencyLevels EachQuorum { get; } = new CassandraSourceReadConsistencyLevels(EachQuorumValue);
        /// <summary> QUORUM. </summary>
        public static CassandraSourceReadConsistencyLevels Quorum { get; } = new CassandraSourceReadConsistencyLevels(QuorumValue);
        /// <summary> LOCAL_QUORUM. </summary>
        public static CassandraSourceReadConsistencyLevels LocalQuorum { get; } = new CassandraSourceReadConsistencyLevels(LocalQuorumValue);
        /// <summary> ONE. </summary>
        public static CassandraSourceReadConsistencyLevels ONE { get; } = new CassandraSourceReadConsistencyLevels(ONEValue);
        /// <summary> TWO. </summary>
        public static CassandraSourceReadConsistencyLevels TWO { get; } = new CassandraSourceReadConsistencyLevels(TWOValue);
        /// <summary> THREE. </summary>
        public static CassandraSourceReadConsistencyLevels Three { get; } = new CassandraSourceReadConsistencyLevels(ThreeValue);
        /// <summary> LOCAL_ONE. </summary>
        public static CassandraSourceReadConsistencyLevels LocalONE { get; } = new CassandraSourceReadConsistencyLevels(LocalONEValue);
        /// <summary> SERIAL. </summary>
        public static CassandraSourceReadConsistencyLevels Serial { get; } = new CassandraSourceReadConsistencyLevels(SerialValue);
        /// <summary> LOCAL_SERIAL. </summary>
        public static CassandraSourceReadConsistencyLevels LocalSerial { get; } = new CassandraSourceReadConsistencyLevels(LocalSerialValue);
        /// <summary> Determines if two <see cref="CassandraSourceReadConsistencyLevels"/> values are the same. </summary>
        public static bool operator ==(CassandraSourceReadConsistencyLevels left, CassandraSourceReadConsistencyLevels right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CassandraSourceReadConsistencyLevels"/> values are not the same. </summary>
        public static bool operator !=(CassandraSourceReadConsistencyLevels left, CassandraSourceReadConsistencyLevels right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CassandraSourceReadConsistencyLevels"/>. </summary>
        public static implicit operator CassandraSourceReadConsistencyLevels(string value) => new CassandraSourceReadConsistencyLevels(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CassandraSourceReadConsistencyLevels other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CassandraSourceReadConsistencyLevels other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
