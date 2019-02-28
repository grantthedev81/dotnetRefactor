// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Enrollment Windows Hello For Business Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceEnrollmentWindowsHelloForBusinessConfiguration : DeviceEnrollmentConfiguration
    {
    
        /// <summary>
        /// Gets or sets pin minimum length.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin maximum length.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinMaximumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinMaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets pin uppercase characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinUppercaseCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinUppercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin lowercase characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinLowercaseCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinLowercaseCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets pin special characters usage.
        /// Not yet documented. Possible values are: allowed, required, disallowed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinSpecialCharactersUsage", Required = Newtonsoft.Json.Required.Default)]
        public WindowsHelloForBusinessPinUsage? PinSpecialCharactersUsage { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Not yet documented. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? State { get; set; }
    
        /// <summary>
        /// Gets or sets security device required.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "securityDeviceRequired", Required = Newtonsoft.Json.Required.Default)]
        public bool? SecurityDeviceRequired { get; set; }
    
        /// <summary>
        /// Gets or sets unlock with biometrics enabled.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unlockWithBiometricsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? UnlockWithBiometricsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets remote passport enabled.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remotePassportEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? RemotePassportEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets pin previous block count.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinPreviousBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinPreviousBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets pin expiration in days.
        /// Not yet documented
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pinExpirationInDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PinExpirationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets enhanced biometrics state.
        /// Not yet documented. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enhancedBiometricsState", Required = Newtonsoft.Json.Required.Default)]
        public Enablement? EnhancedBiometricsState { get; set; }
    
    }
}

