// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The AvroCompressionCodec. </summary>
    internal readonly partial struct AvroCompressionCodec : IEquatable<AvroCompressionCodec>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AvroCompressionCodec"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AvroCompressionCodec(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string DeflateValue = "deflate";
        private const string SnappyValue = "snappy";
        private const string XzValue = "xz";
        private const string Bzip2Value = "bzip2";

        /// <summary> none. </summary>
        public static AvroCompressionCodec None { get; } = new AvroCompressionCodec(NoneValue);
        /// <summary> deflate. </summary>
        public static AvroCompressionCodec Deflate { get; } = new AvroCompressionCodec(DeflateValue);
        /// <summary> snappy. </summary>
        public static AvroCompressionCodec Snappy { get; } = new AvroCompressionCodec(SnappyValue);
        /// <summary> xz. </summary>
        public static AvroCompressionCodec Xz { get; } = new AvroCompressionCodec(XzValue);
        /// <summary> bzip2. </summary>
        public static AvroCompressionCodec Bzip2 { get; } = new AvroCompressionCodec(Bzip2Value);
        /// <summary> Determines if two <see cref="AvroCompressionCodec"/> values are the same. </summary>
        public static bool operator ==(AvroCompressionCodec left, AvroCompressionCodec right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AvroCompressionCodec"/> values are not the same. </summary>
        public static bool operator !=(AvroCompressionCodec left, AvroCompressionCodec right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AvroCompressionCodec"/>. </summary>
        public static implicit operator AvroCompressionCodec(string value) => new AvroCompressionCodec(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AvroCompressionCodec other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AvroCompressionCodec other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
