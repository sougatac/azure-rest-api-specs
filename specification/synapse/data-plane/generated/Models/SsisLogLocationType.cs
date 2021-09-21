// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The type of SSIS log location. </summary>
    public readonly partial struct SsisLogLocationType : IEquatable<SsisLogLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SsisLogLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SsisLogLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FileValue = "File";

        /// <summary> File. </summary>
        public static SsisLogLocationType File { get; } = new SsisLogLocationType(FileValue);
        /// <summary> Determines if two <see cref="SsisLogLocationType"/> values are the same. </summary>
        public static bool operator ==(SsisLogLocationType left, SsisLogLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SsisLogLocationType"/> values are not the same. </summary>
        public static bool operator !=(SsisLogLocationType left, SsisLogLocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SsisLogLocationType"/>. </summary>
        public static implicit operator SsisLogLocationType(string value) => new SsisLogLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SsisLogLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SsisLogLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
