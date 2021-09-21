// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> Data Lake Analytics U-SQL activity. </summary>
    public partial class DataLakeAnalyticsUsqlActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsUsqlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="scriptPath"> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="scriptPath"/>, or <paramref name="scriptLinkedService"/> is null. </exception>
        public DataLakeAnalyticsUsqlActivity(string name, object scriptPath, LinkedServiceReference scriptLinkedService) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (scriptPath == null)
            {
                throw new ArgumentNullException(nameof(scriptPath));
            }
            if (scriptLinkedService == null)
            {
                throw new ArgumentNullException(nameof(scriptLinkedService));
            }

            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Parameters = new ChangeTrackingDictionary<string, object>();
            Type = "DataLakeAnalyticsU-SQL";
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsUsqlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="scriptPath"> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="degreeOfParallelism"> The maximum number of nodes simultaneously used to run the job. Default value is 1. Type: integer (or Expression with resultType integer), minimum: 1. </param>
        /// <param name="priority"> Determines which jobs out of all that are queued should be selected to run first. The lower the number, the higher the priority. Default value is 1000. Type: integer (or Expression with resultType integer), minimum: 1. </param>
        /// <param name="parameters"> Parameters for U-SQL job request. </param>
        /// <param name="runtimeVersion"> Runtime version of the U-SQL engine to use. Type: string (or Expression with resultType string). </param>
        /// <param name="compilationMode"> Compilation mode of U-SQL. Must be one of these values : Semantic, Full and SingleBox. Type: string (or Expression with resultType string). </param>
        internal DataLakeAnalyticsUsqlActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object scriptPath, LinkedServiceReference scriptLinkedService, object degreeOfParallelism, object priority, IDictionary<string, object> parameters, object runtimeVersion, object compilationMode) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            DegreeOfParallelism = degreeOfParallelism;
            Priority = priority;
            Parameters = parameters;
            RuntimeVersion = runtimeVersion;
            CompilationMode = compilationMode;
            Type = type ?? "DataLakeAnalyticsU-SQL";
        }

        /// <summary> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </summary>
        public object ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public LinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary> The maximum number of nodes simultaneously used to run the job. Default value is 1. Type: integer (or Expression with resultType integer), minimum: 1. </summary>
        public object DegreeOfParallelism { get; set; }
        /// <summary> Determines which jobs out of all that are queued should be selected to run first. The lower the number, the higher the priority. Default value is 1000. Type: integer (or Expression with resultType integer), minimum: 1. </summary>
        public object Priority { get; set; }
        /// <summary> Parameters for U-SQL job request. </summary>
        public IDictionary<string, object> Parameters { get; }
        /// <summary> Runtime version of the U-SQL engine to use. Type: string (or Expression with resultType string). </summary>
        public object RuntimeVersion { get; set; }
        /// <summary> Compilation mode of U-SQL. Must be one of these values : Semantic, Full and SingleBox. Type: string (or Expression with resultType string). </summary>
        public object CompilationMode { get; set; }
    }
}
