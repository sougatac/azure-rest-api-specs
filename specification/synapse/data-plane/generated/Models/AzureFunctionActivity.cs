// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace ArtifactsClient.Models
{
    /// <summary> Azure Function activity. </summary>
    public partial class AzureFunctionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of AzureFunctionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="functionName"> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="functionName"/> is null. </exception>
        public AzureFunctionActivity(string name, AzureFunctionActivityMethod method, object functionName) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (functionName == null)
            {
                throw new ArgumentNullException(nameof(functionName));
            }

            Method = method;
            FunctionName = functionName;
            Type = "AzureFunctionActivity";
        }

        /// <summary> Initializes a new instance of AzureFunctionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="method"> Rest API method for target endpoint. </param>
        /// <param name="functionName"> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </param>
        /// <param name="headers"> Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string). </param>
        /// <param name="body"> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </param>
        internal AzureFunctionActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, AzureFunctionActivityMethod method, object functionName, object headers, object body) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Method = method;
            FunctionName = functionName;
            Headers = headers;
            Body = body;
            Type = type ?? "AzureFunctionActivity";
        }

        /// <summary> Rest API method for target endpoint. </summary>
        public AzureFunctionActivityMethod Method { get; set; }
        /// <summary> Name of the Function that the Azure Function Activity will call. Type: string (or Expression with resultType string). </summary>
        public object FunctionName { get; set; }
        /// <summary> Represents the headers that will be sent to the request. For example, to set the language and type on a request: &quot;headers&quot; : { &quot;Accept-Language&quot;: &quot;en-us&quot;, &quot;Content-Type&quot;: &quot;application/json&quot; }. Type: string (or Expression with resultType string). </summary>
        public object Headers { get; set; }
        /// <summary> Represents the payload that will be sent to the endpoint. Required for POST/PUT method, not allowed for GET method Type: string (or Expression with resultType string). </summary>
        public object Body { get; set; }
    }
}
