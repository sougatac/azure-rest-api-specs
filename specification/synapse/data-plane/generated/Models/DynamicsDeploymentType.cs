// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> The deployment type of the Dynamics instance. &apos;Online&apos; for Dynamics Online and &apos;OnPremisesWithIfd&apos; for Dynamics on-premises with Ifd. Type: string (or Expression with resultType string). </summary>
    public readonly partial struct DynamicsDeploymentType : IEquatable<DynamicsDeploymentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DynamicsDeploymentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DynamicsDeploymentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnlineValue = "Online";
        private const string OnPremisesWithIfdValue = "OnPremisesWithIfd";

        /// <summary> Online. </summary>
        public static DynamicsDeploymentType Online { get; } = new DynamicsDeploymentType(OnlineValue);
        /// <summary> OnPremisesWithIfd. </summary>
        public static DynamicsDeploymentType OnPremisesWithIfd { get; } = new DynamicsDeploymentType(OnPremisesWithIfdValue);
        /// <summary> Determines if two <see cref="DynamicsDeploymentType"/> values are the same. </summary>
        public static bool operator ==(DynamicsDeploymentType left, DynamicsDeploymentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DynamicsDeploymentType"/> values are not the same. </summary>
        public static bool operator !=(DynamicsDeploymentType left, DynamicsDeploymentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DynamicsDeploymentType"/>. </summary>
        public static implicit operator DynamicsDeploymentType(string value) => new DynamicsDeploymentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DynamicsDeploymentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DynamicsDeploymentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
