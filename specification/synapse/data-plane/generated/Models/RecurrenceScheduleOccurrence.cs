// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> The recurrence schedule occurrence. </summary>
    public partial class RecurrenceScheduleOccurrence
    {
        /// <summary> Initializes a new instance of RecurrenceScheduleOccurrence. </summary>
        public RecurrenceScheduleOccurrence()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of RecurrenceScheduleOccurrence. </summary>
        /// <param name="day"> The day of the week. </param>
        /// <param name="occurrence"> The occurrence. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal RecurrenceScheduleOccurrence(DayOfWeek? day, int? occurrence, IDictionary<string, object> additionalProperties)
        {
            Day = day;
            Occurrence = occurrence;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The day of the week. </summary>
        public DayOfWeek? Day { get; set; }
        /// <summary> The occurrence. </summary>
        public int? Occurrence { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
