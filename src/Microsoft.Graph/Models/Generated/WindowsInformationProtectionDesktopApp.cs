// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type WindowsInformationProtectionDesktopApp.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsInformationProtectionDesktopApp : WindowsInformationProtectionApp
    {
        public WindowsInformationProtectionDesktopApp()
        {
            this.ODataType = "microsoft.graph.windowsInformationProtectionDesktopApp";
        }
        /// <summary>
        /// Gets or sets binaryName.
        /// The binary name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "binaryName", Required = Newtonsoft.Json.Required.Default)]
        public string BinaryName { get; set; }
    
        /// <summary>
        /// Gets or sets binaryVersionLow.
        /// The lower binary version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "binaryVersionLow", Required = Newtonsoft.Json.Required.Default)]
        public string BinaryVersionLow { get; set; }
    
        /// <summary>
        /// Gets or sets binaryVersionHigh.
        /// The high binary version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "binaryVersionHigh", Required = Newtonsoft.Json.Required.Default)]
        public string BinaryVersionHigh { get; set; }
    
    }
}
