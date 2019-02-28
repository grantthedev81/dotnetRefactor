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
    /// The type DeviceHealthAttestationState.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DeviceHealthAttestationState
    {

        /// <summary>
        /// Gets or sets lastUpdateDateTime.
        /// The Timestamp of the last update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastUpdateDateTime", Required = Newtonsoft.Json.Required.Default)]
        public string LastUpdateDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets contentNamespaceUrl.
        /// The DHA report version. (Namespace version)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentNamespaceUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ContentNamespaceUrl { get; set; }
    
        /// <summary>
        /// Gets or sets deviceHealthAttestationStatus.
        /// The DHA report version. (Namespace version)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceHealthAttestationStatus", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceHealthAttestationStatus { get; set; }
    
        /// <summary>
        /// Gets or sets contentVersion.
        /// The HealthAttestation state schema version
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ContentVersion { get; set; }
    
        /// <summary>
        /// Gets or sets issuedDateTime.
        /// The DateTime when device was evaluated or issued to MDM
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "issuedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? IssuedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets attestationIdentityKey.
        /// TWhen an Attestation Identity Key (AIK) is present on a device, it indicates that the device has an endorsement key (EK) certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "attestationIdentityKey", Required = Newtonsoft.Json.Required.Default)]
        public string AttestationIdentityKey { get; set; }
    
        /// <summary>
        /// Gets or sets resetCount.
        /// The number of times a PC device has hibernated or resumed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "resetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? ResetCount { get; set; }
    
        /// <summary>
        /// Gets or sets restartCount.
        /// The number of times a PC device has rebooted
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restartCount", Required = Newtonsoft.Json.Required.Default)]
        public Int64? RestartCount { get; set; }
    
        /// <summary>
        /// Gets or sets dataExcutionPolicy.
        /// DEP Policy defines a set of hardware and software technologies that perform additional checks on memory
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dataExcutionPolicy", Required = Newtonsoft.Json.Required.Default)]
        public string DataExcutionPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets bitLockerStatus.
        /// On or Off of BitLocker Drive Encryption
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bitLockerStatus", Required = Newtonsoft.Json.Required.Default)]
        public string BitLockerStatus { get; set; }
    
        /// <summary>
        /// Gets or sets bootManagerVersion.
        /// The version of the Boot Manager
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bootManagerVersion", Required = Newtonsoft.Json.Required.Default)]
        public string BootManagerVersion { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrityCheckVersion.
        /// The version of the Boot Manager
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "codeIntegrityCheckVersion", Required = Newtonsoft.Json.Required.Default)]
        public string CodeIntegrityCheckVersion { get; set; }
    
        /// <summary>
        /// Gets or sets secureBoot.
        /// When Secure Boot is enabled, the core components must have the correct cryptographic signatures
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureBoot", Required = Newtonsoft.Json.Required.Default)]
        public string SecureBoot { get; set; }
    
        /// <summary>
        /// Gets or sets bootDebugging.
        /// When bootDebugging is enabled, the device is used in development and testing
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bootDebugging", Required = Newtonsoft.Json.Required.Default)]
        public string BootDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemKernelDebugging.
        /// When operatingSystemKernelDebugging is enabled, the device is used in development and testing
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemKernelDebugging", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystemKernelDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrity.
        /// When code integrity is enabled, code execution is restricted to integrity verified code
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "codeIntegrity", Required = Newtonsoft.Json.Required.Default)]
        public string CodeIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets testSigning.
        /// When test signing is allowed, the device does not enforce signature validation during boot
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "testSigning", Required = Newtonsoft.Json.Required.Default)]
        public string TestSigning { get; set; }
    
        /// <summary>
        /// Gets or sets safeMode.
        /// Safe mode is a troubleshooting option for Windows that starts your computer in a limited state
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "safeMode", Required = Newtonsoft.Json.Required.Default)]
        public string SafeMode { get; set; }
    
        /// <summary>
        /// Gets or sets windowsPE.
        /// Operating system running with limited services that is used to prepare a computer for Windows
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsPE", Required = Newtonsoft.Json.Required.Default)]
        public string WindowsPE { get; set; }
    
        /// <summary>
        /// Gets or sets earlyLaunchAntiMalwareDriverProtection.
        /// ELAM provides protection for the computers in your network when they start up
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "earlyLaunchAntiMalwareDriverProtection", Required = Newtonsoft.Json.Required.Default)]
        public string EarlyLaunchAntiMalwareDriverProtection { get; set; }
    
        /// <summary>
        /// Gets or sets virtualSecureMode.
        /// VSM is a container that protects high value assets from a compromised kernel
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "virtualSecureMode", Required = Newtonsoft.Json.Required.Default)]
        public string VirtualSecureMode { get; set; }
    
        /// <summary>
        /// Gets or sets pcrHashAlgorithm.
        /// Informational attribute that identifies the HASH algorithm that was used by TPM
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pcrHashAlgorithm", Required = Newtonsoft.Json.Required.Default)]
        public string PcrHashAlgorithm { get; set; }
    
        /// <summary>
        /// Gets or sets bootAppSecurityVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bootAppSecurityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string BootAppSecurityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets bootManagerSecurityVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bootManagerSecurityVersion", Required = Newtonsoft.Json.Required.Default)]
        public string BootManagerSecurityVersion { get; set; }
    
        /// <summary>
        /// Gets or sets tpmVersion.
        /// The security version number of the Boot Application
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tpmVersion", Required = Newtonsoft.Json.Required.Default)]
        public string TpmVersion { get; set; }
    
        /// <summary>
        /// Gets or sets pcr0.
        /// The measurement that is captured in PCR[0]
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pcr0", Required = Newtonsoft.Json.Required.Default)]
        public string Pcr0 { get; set; }
    
        /// <summary>
        /// Gets or sets secureBootConfigurationPolicyFingerPrint.
        /// Fingerprint of the Custom Secure Boot Configuration Policy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "secureBootConfigurationPolicyFingerPrint", Required = Newtonsoft.Json.Required.Default)]
        public string SecureBootConfigurationPolicyFingerPrint { get; set; }
    
        /// <summary>
        /// Gets or sets codeIntegrityPolicy.
        /// The Code Integrity policy that is controlling the security of the boot environment
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "codeIntegrityPolicy", Required = Newtonsoft.Json.Required.Default)]
        public string CodeIntegrityPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets bootRevisionListInfo.
        /// The Boot Revision List that was loaded during initial boot on the attested device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bootRevisionListInfo", Required = Newtonsoft.Json.Required.Default)]
        public string BootRevisionListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystemRevListInfo.
        /// The Operating System Revision List that was loaded during initial boot on the attested device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operatingSystemRevListInfo", Required = Newtonsoft.Json.Required.Default)]
        public string OperatingSystemRevListInfo { get; set; }
    
        /// <summary>
        /// Gets or sets healthStatusMismatchInfo.
        /// This attribute appears if DHA-Service detects an integrity issue
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthStatusMismatchInfo", Required = Newtonsoft.Json.Required.Default)]
        public string HealthStatusMismatchInfo { get; set; }
    
        /// <summary>
        /// Gets or sets healthAttestationSupportedStatus.
        /// This attribute indicates if DHA is supported for the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "healthAttestationSupportedStatus", Required = Newtonsoft.Json.Required.Default)]
        public string HealthAttestationSupportedStatus { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
