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
    /// The type License Details.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class LicenseDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets service plans.
        /// Information about the service plans assigned with the license. Read-only, Not nullable
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servicePlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ServicePlanInfo> ServicePlans { get; set; }
    
        /// <summary>
        /// Gets or sets sku id.
        /// Unique identifier (GUID) for the service SKU. Equal to the skuId property on the related SubscribedSku object. Read-only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? SkuId { get; set; }
    
        /// <summary>
        /// Gets or sets sku part number.
        /// Unique SKU display name. Equal to the skuPartNumber on the related SubscribedSku object; for example: 'AAD_Premium'. Read-only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuPartNumber", Required = Newtonsoft.Json.Required.Default)]
        public string SkuPartNumber { get; set; }
    
    }
}

