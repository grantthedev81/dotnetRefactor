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
    /// The type IosNotificationSettings.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IosNotificationSettings
    {

        /// <summary>
        /// Gets or sets bundleID.
        /// Bundle id of app to which to apply these notification settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bundleID", Required = Newtonsoft.Json.Required.Default)]
        public string BundleID { get; set; }
    
        /// <summary>
        /// Gets or sets appName.
        /// Application name to be associated with the bundleID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appName", Required = Newtonsoft.Json.Required.Default)]
        public string AppName { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// Publisher to be associated with the bundleID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "publisher", Required = Newtonsoft.Json.Required.Default)]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets enabled.
        /// Indicates whether notifications are allowed for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or sets showInNotificationCenter.
        /// Indicates whether notifications can be shown in notification center.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showInNotificationCenter", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowInNotificationCenter { get; set; }
    
        /// <summary>
        /// Gets or sets showOnLockScreen.
        /// Indicates whether notifications can be shown on the lock screen.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showOnLockScreen", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowOnLockScreen { get; set; }
    
        /// <summary>
        /// Gets or sets alertType.
        /// Indicates the type of alert for notifications for this app. Possible values are: deviceDefault, banner, modal, none.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alertType", Required = Newtonsoft.Json.Required.Default)]
        public IosNotificationAlertType? AlertType { get; set; }
    
        /// <summary>
        /// Gets or sets badgesEnabled.
        /// Indicates whether badges are allowed for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "badgesEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? BadgesEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets soundsEnabled.
        /// Indicates whether sounds are allowed for this app.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "soundsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SoundsEnabled { get; set; }
    
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
