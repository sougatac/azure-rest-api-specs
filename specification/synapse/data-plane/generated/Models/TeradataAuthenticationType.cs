// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> AuthenticationType to be used for connection. </summary>
    public readonly partial struct TeradataAuthenticationType : IEquatable<TeradataAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TeradataAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TeradataAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string WindowsValue = "Windows";

        /// <summary> Basic. </summary>
        public static TeradataAuthenticationType Basic { get; } = new TeradataAuthenticationType(BasicValue);
        /// <summary> Windows. </summary>
        public static TeradataAuthenticationType Windows { get; } = new TeradataAuthenticationType(WindowsValue);
        /// <summary> Determines if two <see cref="TeradataAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(TeradataAuthenticationType left, TeradataAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TeradataAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(TeradataAuthenticationType left, TeradataAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TeradataAuthenticationType"/>. </summary>
        public static implicit operator TeradataAuthenticationType(string value) => new TeradataAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TeradataAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TeradataAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
