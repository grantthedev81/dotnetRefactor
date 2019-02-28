// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ManagedDevicePartnerReportedHealthState.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ManagedDevicePartnerReportedHealthState
    {
    
        /// <summary>
        /// unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// activated
        /// </summary>
        Activated = 1,
	
        /// <summary>
        /// deactivated
        /// </summary>
        Deactivated = 2,
	
        /// <summary>
        /// secured
        /// </summary>
        Secured = 3,
	
        /// <summary>
        /// low Severity
        /// </summary>
        LowSeverity = 4,
	
        /// <summary>
        /// medium Severity
        /// </summary>
        MediumSeverity = 5,
	
        /// <summary>
        /// high Severity
        /// </summary>
        HighSeverity = 6,
	
        /// <summary>
        /// unresponsive
        /// </summary>
        Unresponsive = 7,
	
        /// <summary>
        /// compromised
        /// </summary>
        Compromised = 8,
	
        /// <summary>
        /// misconfigured
        /// </summary>
        Misconfigured = 9,
	
    }
}
