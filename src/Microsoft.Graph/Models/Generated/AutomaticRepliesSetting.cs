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
    /// The type AutomaticRepliesSetting.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AutomaticRepliesSetting
    {

        /// <summary>
        /// Gets or sets status.
        /// Configurations status for automatic replies. The possible values are: disabled, alwaysEnabled, scheduled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public AutomaticRepliesStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets externalAudience.
        /// The set of audience external to the signed-in user's organization who will receive the ExternalReplyMessage, if Status is AlwaysEnabled or Scheduled. The possible values are: none, contactsOnly, all.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalAudience", Required = Newtonsoft.Json.Required.Default)]
        public ExternalAudienceScope? ExternalAudience { get; set; }
    
        /// <summary>
        /// Gets or sets scheduledStartDateTime.
        /// The date and time that automatic replies are set to begin, if Status is set to Scheduled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduledStartDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone ScheduledStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets scheduledEndDateTime.
        /// The date and time that automatic replies are set to end, if Status is set to Scheduled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scheduledEndDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone ScheduledEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets internalReplyMessage.
        /// The automatic reply to send to the audience internal to the signed-in user's organization, if Status is AlwaysEnabled or Scheduled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "internalReplyMessage", Required = Newtonsoft.Json.Required.Default)]
        public string InternalReplyMessage { get; set; }
    
        /// <summary>
        /// Gets or sets externalReplyMessage.
        /// The automatic reply to send to the specified external audience, if Status is AlwaysEnabled or Scheduled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "externalReplyMessage", Required = Newtonsoft.Json.Required.Default)]
        public string ExternalReplyMessage { get; set; }
    
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
