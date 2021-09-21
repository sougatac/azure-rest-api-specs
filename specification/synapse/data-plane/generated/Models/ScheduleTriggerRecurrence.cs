// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> The workflow trigger recurrence. </summary>
    public partial class ScheduleTriggerRecurrence
    {
        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        public ScheduleTriggerRecurrence()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ScheduleTriggerRecurrence. </summary>
        /// <param name="frequency"> The frequency. </param>
        /// <param name="interval"> The interval. </param>
        /// <param name="startTime"> The start time. </param>
        /// <param name="endTime"> The end time. </param>
        /// <param name="timeZone"> The time zone. </param>
        /// <param name="schedule"> The recurrence schedule. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal ScheduleTriggerRecurrence(RecurrenceFrequency? frequency, int? interval, DateTimeOffset? startTime, DateTimeOffset? endTime, string timeZone, RecurrenceSchedule schedule, IDictionary<string, object> additionalProperties)
        {
            Frequency = frequency;
            Interval = interval;
            StartTime = startTime;
            EndTime = endTime;
            TimeZone = timeZone;
            Schedule = schedule;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The frequency. </summary>
        public RecurrenceFrequency? Frequency { get; set; }
        /// <summary> The interval. </summary>
        public int? Interval { get; set; }
        /// <summary> The start time. </summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary> The end time. </summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary> The time zone. </summary>
        public string TimeZone { get; set; }
        /// <summary> The recurrence schedule. </summary>
        public RecurrenceSchedule Schedule { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
