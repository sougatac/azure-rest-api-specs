// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> Sorting order of the parameter. </summary>
    public readonly partial struct RunQueryOrder : IEquatable<RunQueryOrder>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunQueryOrder"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunQueryOrder(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ASCValue = "ASC";
        private const string DescValue = "DESC";

        /// <summary> ASC. </summary>
        public static RunQueryOrder ASC { get; } = new RunQueryOrder(ASCValue);
        /// <summary> DESC. </summary>
        public static RunQueryOrder Desc { get; } = new RunQueryOrder(DescValue);
        /// <summary> Determines if two <see cref="RunQueryOrder"/> values are the same. </summary>
        public static bool operator ==(RunQueryOrder left, RunQueryOrder right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunQueryOrder"/> values are not the same. </summary>
        public static bool operator !=(RunQueryOrder left, RunQueryOrder right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunQueryOrder"/>. </summary>
        public static implicit operator RunQueryOrder(string value) => new RunQueryOrder(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunQueryOrder other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunQueryOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
