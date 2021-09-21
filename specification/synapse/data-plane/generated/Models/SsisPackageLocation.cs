// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace ArtifactsClient.Models
{
    /// <summary> SSIS package location. </summary>
    public partial class SsisPackageLocation
    {
        /// <summary> Initializes a new instance of SsisPackageLocation. </summary>
        public SsisPackageLocation()
        {
            ChildPackages = new ChangeTrackingList<SsisChildPackage>();
        }

        /// <summary> Initializes a new instance of SsisPackageLocation. </summary>
        /// <param name="packagePath"> The SSIS package path. Type: string (or Expression with resultType string). </param>
        /// <param name="type"> The type of SSIS package location. </param>
        /// <param name="packagePassword"> Password of the package. </param>
        /// <param name="accessCredential"> The package access credential. </param>
        /// <param name="configurationPath"> The configuration file of the package execution. Type: string (or Expression with resultType string). </param>
        /// <param name="configurationAccessCredential"> The configuration file access credential. </param>
        /// <param name="packageName"> The package name. </param>
        /// <param name="packageContent"> The embedded package content. Type: string (or Expression with resultType string). </param>
        /// <param name="packageLastModifiedDate"> The embedded package last modified date. </param>
        /// <param name="childPackages"> The embedded child package list. </param>
        internal SsisPackageLocation(object packagePath, SsisPackageLocationType? type, SecretBase packagePassword, SsisAccessCredential accessCredential, object configurationPath, SsisAccessCredential configurationAccessCredential, string packageName, object packageContent, string packageLastModifiedDate, IList<SsisChildPackage> childPackages)
        {
            PackagePath = packagePath;
            Type = type;
            PackagePassword = packagePassword;
            AccessCredential = accessCredential;
            ConfigurationPath = configurationPath;
            ConfigurationAccessCredential = configurationAccessCredential;
            PackageName = packageName;
            PackageContent = packageContent;
            PackageLastModifiedDate = packageLastModifiedDate;
            ChildPackages = childPackages;
        }

        /// <summary> The SSIS package path. Type: string (or Expression with resultType string). </summary>
        public object PackagePath { get; set; }
        /// <summary> The type of SSIS package location. </summary>
        public SsisPackageLocationType? Type { get; set; }
        /// <summary> Password of the package. </summary>
        public SecretBase PackagePassword { get; set; }
        /// <summary> The package access credential. </summary>
        public SsisAccessCredential AccessCredential { get; set; }
        /// <summary> The configuration file of the package execution. Type: string (or Expression with resultType string). </summary>
        public object ConfigurationPath { get; set; }
        /// <summary> The configuration file access credential. </summary>
        public SsisAccessCredential ConfigurationAccessCredential { get; set; }
        /// <summary> The package name. </summary>
        public string PackageName { get; set; }
        /// <summary> The embedded package content. Type: string (or Expression with resultType string). </summary>
        public object PackageContent { get; set; }
        /// <summary> The embedded package last modified date. </summary>
        public string PackageLastModifiedDate { get; set; }
        /// <summary> The embedded child package list. </summary>
        public IList<SsisChildPackage> ChildPackages { get; }
    }
}
