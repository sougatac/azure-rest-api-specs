// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace ArtifactsClient.Models
{
    /// <summary> Event Subscription Status. </summary>
    public readonly partial struct EventSubscriptionStatus : IEquatable<EventSubscriptionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventSubscriptionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string ProvisioningValue = "Provisioning";
        private const string DeprovisioningValue = "Deprovisioning";
        private const string DisabledValue = "Disabled";
        private const string UnknownValue = "Unknown";

        /// <summary> Enabled. </summary>
        public static EventSubscriptionStatus Enabled { get; } = new EventSubscriptionStatus(EnabledValue);
        /// <summary> Provisioning. </summary>
        public static EventSubscriptionStatus Provisioning { get; } = new EventSubscriptionStatus(ProvisioningValue);
        /// <summary> Deprovisioning. </summary>
        public static EventSubscriptionStatus Deprovisioning { get; } = new EventSubscriptionStatus(DeprovisioningValue);
        /// <summary> Disabled. </summary>
        public static EventSubscriptionStatus Disabled { get; } = new EventSubscriptionStatus(DisabledValue);
        /// <summary> Unknown. </summary>
        public static EventSubscriptionStatus Unknown { get; } = new EventSubscriptionStatus(UnknownValue);
        /// <summary> Determines if two <see cref="EventSubscriptionStatus"/> values are the same. </summary>
        public static bool operator ==(EventSubscriptionStatus left, EventSubscriptionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventSubscriptionStatus"/> values are not the same. </summary>
        public static bool operator !=(EventSubscriptionStatus left, EventSubscriptionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventSubscriptionStatus"/>. </summary>
        public static implicit operator EventSubscriptionStatus(string value) => new EventSubscriptionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventSubscriptionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventSubscriptionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
