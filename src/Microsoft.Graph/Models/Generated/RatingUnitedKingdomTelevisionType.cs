// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RatingUnitedKingdomTelevisionType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RatingUnitedKingdomTelevisionType
    {
    
        /// <summary>
        /// all Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// all Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// caution
        /// </summary>
        Caution = 2,
	
    }
}
