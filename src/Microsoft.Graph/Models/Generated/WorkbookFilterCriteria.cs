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
    /// The type WorkbookFilterCriteria.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class WorkbookFilterCriteria
    {

        /// <summary>
        /// Gets or sets color.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "color", Required = Newtonsoft.Json.Required.Default)]
        public string Color { get; set; }
    
        /// <summary>
        /// Gets or sets criterion1.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criterion1", Required = Newtonsoft.Json.Required.Default)]
        public string Criterion1 { get; set; }
    
        /// <summary>
        /// Gets or sets criterion2.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "criterion2", Required = Newtonsoft.Json.Required.Default)]
        public string Criterion2 { get; set; }
    
        /// <summary>
        /// Gets or sets dynamicCriteria.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dynamicCriteria", Required = Newtonsoft.Json.Required.Default)]
        public string DynamicCriteria { get; set; }
    
        /// <summary>
        /// Gets or sets filterOn.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filterOn", Required = Newtonsoft.Json.Required.Default)]
        public string FilterOn { get; set; }
    
        /// <summary>
        /// Gets or sets icon.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "icon", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookIcon Icon { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public string Operator { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
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